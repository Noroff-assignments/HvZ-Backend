using hvz_backend.Models;
using hvz_backend.Services.GameServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using hvz_backend;
using hvz_backend.Services.MapServices;
using hvz_backend.Services.KillServices;
using hvz_backend.Services.MissionServices;
using hvz_backend.Services.PlayerServices;
using hvz_backend.Services.SafezoneServices;
using hvz_backend.Services.SquadServices;
using hvz_backend.Services.SupplyServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string myCorsPolicy = "_myAllowSpecificOrigens";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myCorsPolicy,
        policy =>
        {
            policy.WithOrigins("http://localhost:3000", "https://hvzweb.azurewebsites.net/").AllowAnyHeader().AllowAnyMethod();
        });
});


builder.Services.AddControllers();
builder.Services.AddDbContext<HvZDbContext>(
    options => options.UseSqlServer(builder.Configuration["DefaultConnection"])
    );
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle .
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddEndpointsApiExplorer();

var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Web API for Human vs. Zombies database.",
        Description = "Help tool for the Game Master of a game of Humans vs. Zombies.",
        Contact = new OpenApiContact
        {
            Name = "Rene Dam Marcker",
            Url = new Uri("https://github.com/Noroff-assignments/hvz-backend")
        },
        License = new OpenApiLicense
        {
            Name = "MIT 2022",
            Url = new Uri("https://opensource.org/license/mit/")
        }
    });
    options.IncludeXmlComments(xmlPath);
});


PusherConfig.ApiKey = builder.Configuration["Pusher:ApiKey"];
PusherConfig.ApiId = builder.Configuration["Pusher:ApiId"];
PusherConfig.ApiSecret = builder.Configuration["Pusher:Secret"];


// Adds services to the builder
builder.Services.AddTransient<IGameService, GameService>();
builder.Services.AddTransient<IMapService, MapService>();
builder.Services.AddTransient<IKillService, KillService>();
builder.Services.AddTransient<IMissionService, MissionService>();
builder.Services.AddTransient<IPlayerService, PlayerService>();
builder.Services.AddTransient<ISafezoneService, SafezoneService>();
builder.Services.AddTransient<ISquadService, SquadService>();
builder.Services.AddTransient<ISupplyService, SupplyService>();


builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(opt =>
    {
        opt.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidIssuer = builder.Configuration["KeyCloak:IssuerURI"],
            ValidAudience = "account",
            IssuerSigningKeyResolver = (token, SecurityToken, kid, parameters) =>
            {
                var client = new HttpClient();
                var keyuri = builder.Configuration["KeyCloak:KeyURI"];
                var response = client.GetAsync(keyuri).Result;
                var responseString = response.Content.ReadAsStringAsync().Result;
                var keys = new JsonWebKeySet(responseString);
                return keys.Keys;
            }
        };
    });



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    builder.Configuration.AddUserSecrets<Program>();
}

if (app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1"));
}


using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
var dbContext = services.GetRequiredService<HvZDbContext>();

dbContext.Database.Migrate();

app.UseHttpsRedirection();

app.UseCors(myCorsPolicy);

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
