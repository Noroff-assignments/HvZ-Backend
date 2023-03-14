using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace hvz_backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NickName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    State = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeginTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    AdminId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Maps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MapName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MapDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Maps_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Squads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TotalPlayer = table.Column<int>(type: "int", nullable: true),
                    TotalDead = table.Column<int>(type: "int", nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Squads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Squads_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    ZombieVisible = table.Column<bool>(type: "bit", nullable: false),
                    HumanVisible = table.Column<bool>(type: "bit", nullable: false),
                    BeginTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MapId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Missions_Maps_MapId",
                        column: x => x.MapId,
                        principalTable: "Maps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Safezones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Radius = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    ZombieVisible = table.Column<bool>(type: "bit", nullable: false),
                    HumanVisible = table.Column<bool>(type: "bit", nullable: false),
                    BeginTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MapId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Safezones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Safezones_Maps_MapId",
                        column: x => x.MapId,
                        principalTable: "Maps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Supplies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Drop = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    ZombieVisible = table.Column<bool>(type: "bit", nullable: false),
                    HumanVisible = table.Column<bool>(type: "bit", nullable: false),
                    BeginTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MapId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Supplies_Maps_MapId",
                        column: x => x.MapId,
                        principalTable: "Maps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BiteCode = table.Column<int>(type: "int", nullable: false),
                    IsZombie = table.Column<bool>(type: "bit", nullable: false),
                    IsPatientZero = table.Column<bool>(type: "bit", nullable: false),
                    SquadId = table.Column<int>(type: "int", nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Players_Squads_SquadId",
                        column: x => x.SquadId,
                        principalTable: "Squads",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Players_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Mode = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chats_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chats_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Kills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeDead = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeadStory = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    KillerId = table.Column<int>(type: "int", nullable: false),
                    VictimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kills_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kills_Players_KillerId",
                        column: x => x.KillerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kills_Players_VictimId",
                        column: x => x.VictimId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "FirstName", "LastName", "Status" },
                values: new object[,]
                {
                    { 1, "René", "Dam Marcker", 0 },
                    { 2, "Thomas", "Osterhammel", 0 },
                    { 3, "Anja", "Fausing Wilstrup Sundebo", 0 },
                    { 4, "Michael", "Neergaard", 0 }
                });

            migrationBuilder.InsertData(
                table: "Squads",
                columns: new[] { "Id", "Description", "GameId", "Name", "TotalDead", "TotalPlayer" },
                values: new object[,]
                {
                    { 1, "A team of elite soldiers trained in special operations and advanced tactics.", null, "Alpha Squad", null, null },
                    { 2, "A highly skilled unit specializing in airborne operations and lightning fast strikes.", null, "Thunder Squad", null, null },
                    { 3, "A group of resilient soldiers known for their ability to rise from the ashes of defeat.", null, "Phoenix Squad", null, null },
                    { 4, "A covert unit specializing in stealth and infiltration missions.", null, "Ghost Squad", null, null },
                    { 5, "A formidable force of heavily armored soldiers with unparalleled firepower.", null, "Titan Squad", null, null },
                    { 6, "A team of specialists with unique abilities and powers, able to take on any challenge.", null, "Chimera Squad", null, null },
                    { 7, "A group of skilled assassins and covert operatives, operating in the shadows.", null, "Shadow Squad", null, null },
                    { 8, "An all-female unit known for their ferocity and bravery in battle.", null, "Valkyrie Squad", null, null },
                    { 9, "A team of soldiers who fight with a relentless passion and unbridled fury.", null, "Fury Squad", null, null },
                    { 10, "A versatile unit specializing in rapid response and weather-related operations.", null, "Storm Squad", null, null },
                    { 11, "A highly trained unit specializing in close combat and hand-to-hand combat.", null, "Sabre Squad", null, null },
                    { 12, "A unit of soldiers with incredible strength and endurance, capable of moving mountains.", null, "Atlas Squad", null, null },
                    { 13, "A team of soldiers equipped with cutting-edge technology and advanced weaponry.", null, "Omega Squad", null, null },
                    { 14, "A group of highly skilled swordsmen, trained in the art of combat and swordplay.", null, "Blade Squad", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "NickName", "State" },
                values: new object[,]
                {
                    { 1, "Ethan", "Johnson", "Rainbow", null },
                    { 2, "Olivia", "Brown", "Kratos", null },
                    { 3, "Liam", "Martinez", "Sub-Zero", null },
                    { 4, "Emma", "Rodriguez", "Link", null },
                    { 5, "Noah", "Lee", "Zelda", null },
                    { 6, "Ava", "Davis", "Master Chief", null },
                    { 7, "William", "Wilson", "Solid Snake", null },
                    { 8, "Sophia", "Thompson", "AlbertWesker", null },
                    { 9, "James", "White", "Cloud", null },
                    { 10, "Mia", "Hernandez", "Aloy", null },
                    { 11, "Lucas", "Garcia", "Trevor", null },
                    { 12, "Isabella", "Smith", "Dante", null },
                    { 13, "Mason", "Brown", "LaraCroft", null },
                    { 14, "Sophia", "Gonzalez", "John Marston", null },
                    { 15, "Logan", "Perez", "Sam Fisher", null },
                    { 16, "Chloe", "Davis", "Max Payne", null },
                    { 17, "Benjamin", "Wilson", "Nemesis", null },
                    { 18, "Avery", "Taylor", "Ellie", null },
                    { 19, "Evelyn", "Anderson", "Commander Shepard", null },
                    { 20, "Daniel", "Hernandez", "Jill Valentine", null },
                    { 21, "Caleb", "Moore", "Leon S. Kennedy", null },
                    { 22, "Abigail", "Gomez", "Nathan Drake", null },
                    { 23, "Ethan", "Campbell", "Sonic the Hedgehog", null },
                    { 24, "Hannah", "Parker", "Ezio Auditore", null },
                    { 25, "Alexander", "Allen", "Geralt of Rivia", null },
                    { 26, "Madison", "King", "Samus Aran", null },
                    { 27, "Joseph", "Wright", "Raiden", null },
                    { 28, "Avery", "Scott", "Ezra", null },
                    { 29, "Sofia", "Green", "Daenerys", null },
                    { 30, "Christopher", "Baker", "Neo", null },
                    { 31, "Ella", "Adams", "Trinity", null },
                    { 32, "Joshua", "Nelson", "Blade", null },
                    { 33, "Avery", "Carter", "Ripley", null },
                    { 34, "Grace", "Mitchell", "Arya", null },
                    { 35, "Samuel", "Turner", "Wolverine", null },
                    { 36, "Victoria", "Phillips", "Leia", null },
                    { 37, "David", "Campbell", "Spartan", null },
                    { 38, "Aria", "Garcia", "Katniss", null },
                    { 39, "Daniel", "Cruz", "Nikita", null },
                    { 40, "Brianna", "Perez", "Triss", null },
                    { 41, "Joseph", "Bailey", "Indiana", null },
                    { 42, "Audrey", "Evans", "Rip Hunter", null },
                    { 43, "Jacob", "Rivera", "Kraven", null },
                    { 44, "Avery", "Cooper", "Harley", null },
                    { 45, "Natalie", "Reyes", "Mystique", null },
                    { 46, "Elijah", "Collins", "Hannibal", null },
                    { 47, "Elizabeth", "Lee", "Xena", null },
                    { 48, "Benjamin", "Gonzalez", "Bane", null },
                    { 49, "Aaliyah", "Martinez", "Riddick", null },
                    { 50, "Ethan", "Walker", "Morpheus", null },
                    { 51, "Avery", "Hall", "Gambit", null },
                    { 52, "Emily", "Allen", "Violet", null },
                    { 53, "William", "Garcia", "Nathan Hale", null },
                    { 54, "Grace", "Wilson", "Evelyn Salt", null },
                    { 55, "Gabriel", "Anderson", "Spartacus", null },
                    { 56, "Chloe", "Taylor", "Alice Abernathy", null },
                    { 57, "Samuel", "Brown", "Captain John Price", null },
                    { 58, "Lily", "Moore", "Elsa", null },
                    { 59, "David", "Lopez", "Marcus Fenix", null },
                    { 60, "Sofia", "Johnson", "Lena Oxton", null },
                    { 61, "Noah", "Davis", "Chris Redfield", null },
                    { 62, "Avery", "Harris", "Doomguy", null },
                    { 63, "Mia", "Thomas", "Katniss Everdeen", null },
                    { 64, "Daniel", "Allen", "Jason Brody", null },
                    { 65, "Aria", "Young", "Mako Mori", null },
                    { 66, "Jacob", "Nelson", "Ezra Bridger", null },
                    { 67, "Charlotte", "Sanchez", "Rey", null },
                    { 68, "Logan", "Parker", "Geralt of Rivia", null },
                    { 69, "Olivia", "Mitchell", "Wonder Woman", null },
                    { 70, "Caleb", "Clark", "Altair Ibn-La'Ahad", null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AdminId", "BeginTime", "Description", "EndTime", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2023, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "Welcome to the Experis Academy Championship Qualification 1 for Human vs Zombie, the ultimate battle between humanity and the undead. The stage is set, and the contestants are ready to face their fears and fight for survival. As the game begins, the human players are armed with weapons such as guns and grenades while the zombie players rely on their brute strength and contagious bites to infect the human players.The objective of the game is simple. The human players must survive the zombie invasion, while the zombie players must infect all the human players before time runs out. The players must constantly strategize and adapt to the changing game dynamics, find supplies, safezones and clear missions. As the game progress, the game becomes more challenging, and the players must use all their skills and resources to stay alive. The human players must be quick on their feet and accurate with their weapons, while the zombie players must be relentless and work together to corner their prey.The Experis Academy candidates are some of the most talented and skilled players in the game, and the championship promises to be an exciting showcase of their abilities. Who will emerge victorious, the humans or the zombies? Only time will tell. Join us as we witness the ultimate battle between life and death, in the Experis Academy Championship for Human vs Zombie.", new DateTime(2023, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, "Humans vs. Zombies - Experis Academy Championship (Qualification 1)." },
                    { 2, 2, new DateTime(2023, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), "Welcome to the Experis Academy Championship Qualification 2 for Human vs Zombie, the ultimate battle between humanity and the undead. The stage is set, and the contestants are ready to face their fears and fight for survival. As the game begins, the human players are armed with weapons such as guns and grenades while the zombie players rely on their brute strength and contagious bites to infect the human players.The objective of the game is simple. The human players must survive the zombie invasion, while the zombie players must infect all the human players before time runs out. The players must constantly strategize and adapt to the changing game dynamics, find supplies, safezones and clear missions. As the game progress, the game becomes more challenging, and the players must use all their skills and resources to stay alive. The human players must be quick on their feet and accurate with their weapons, while the zombie players must be relentless and work together to corner their prey.The Experis Academy candidates are some of the most talented and skilled players in the game, and the championship promises to be an exciting showcase of their abilities. Who will emerge victorious, the humans or the zombies? Only time will tell. Join us as we witness the ultimate battle between life and death, in the Experis Academy Championship for Human vs Zombie.", new DateTime(2023, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, "Humans vs. Zombies - Experis Academy Championship (Qualification 2)." },
                    { 3, 4, new DateTime(2023, 3, 29, 9, 0, 0, 0, DateTimeKind.Unspecified), "Welcome to the Experis Academy Championship Semifinals for Human vs Zombie, the ultimate battle between humanity and the undead. The stage is set, and the contestants are ready to face their fears and fight for survival. As the game begins, the human players are armed with weapons such as guns and grenades while the zombie players rely on their brute strength and contagious bites to infect the human players.The objective of the game is simple. The human players must survive the zombie invasion, while the zombie players must infect all the human players before time runs out. The players must constantly strategize and adapt to the changing game dynamics, find supplies, safezones and clear missions. As the game progress, the game becomes more challenging, and the players must use all their skills and resources to stay alive. The human players must be quick on their feet and accurate with their weapons, while the zombie players must be relentless and work together to corner their prey.The Experis Academy candidates are some of the most talented and skilled players in the game, and the championship promises to be an exciting showcase of their abilities. Who will emerge victorious, the humans or the zombies? Only time will tell. Join us as we witness the ultimate battle between life and death, in the Experis Academy Championship for Human vs Zombie.", new DateTime(2023, 3, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, "Humans vs. Zombies - Experis Academy Championship - Semifinals." },
                    { 4, 1, new DateTime(2023, 3, 31, 9, 0, 0, 0, DateTimeKind.Unspecified), "Welcome to the Experis Academy Championship finals for Human vs Zombie, the ultimate battle between humanity and the undead. The stage is set, and the contestants are ready to face their fears and fight for survival. As the game begins, the human players are armed with weapons such as guns and grenades while the zombie players rely on their brute strength and contagious bites to infect the human players.The objective of the game is simple. The human players must survive the zombie invasion, while the zombie players must infect all the human players before time runs out. The players must constantly strategize and adapt to the changing game dynamics, find supplies, safezones and clear missions. As the game progress, the game becomes more challenging, and the players must use all their skills and resources to stay alive. The human players must be quick on their feet and accurate with their weapons, while the zombie players must be relentless and work together to corner their prey.The Experis Academy candidates are some of the most talented and skilled players in the game, and the championship promises to be an exciting showcase of their abilities. Who will emerge victorious, the humans or the zombies? Only time will tell. Join us as we witness the ultimate battle between life and death, in the Experis Academy Championship for Human vs Zombie.", new DateTime(2023, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Humans vs. Zombies - Experis Academy Championship - finals." }
                });

            migrationBuilder.InsertData(
                table: "Maps",
                columns: new[] { "Id", "GameId", "Latitude", "Longitude", "MapDescription", "MapName" },
                values: new object[,]
                {
                    { 1, 1, 55.642780000000002, 12.271445, "The location for the Experis Academy World Championship 2023.", "Experis Academy Denmark" },
                    { 2, 2, 55.642780000000002, 12.271445, "The location for the Experis Academy World Championship 2023.", "Experis Academy Denmark" },
                    { 3, 3, 55.642780000000002, 12.271445, "The location for the Experis Academy World Championship 2023.", "Experis Academy Denmark" },
                    { 4, 4, 55.642780000000002, 12.271445, "The location for the Experis Academy World Championship 2023.", "Experis Academy Denmark" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "BiteCode", "GameId", "IsPatientZero", "IsZombie", "SquadId", "UserId" },
                values: new object[,]
                {
                    { 1, 1543, 1, true, true, null, 1 },
                    { 2, 2804, 1, false, false, 2, 2 },
                    { 3, 3110, 1, false, true, 2, 3 },
                    { 4, 4975, 1, false, false, 3, 4 },
                    { 5, 5368, 1, false, false, 3, 5 },
                    { 6, 6729, 1, false, false, null, 6 },
                    { 7, 7462, 1, false, true, 4, 7 },
                    { 8, 8901, 1, false, false, 2, 8 },
                    { 9, 9012, 1, false, true, 1, 9 },
                    { 10, 1098, 1, false, false, null, 10 },
                    { 11, 2109, 1, false, true, null, 11 },
                    { 12, 3210, 1, false, false, 2, 12 },
                    { 13, 8049, 1, false, true, 4, 13 },
                    { 14, 9127, 1, false, false, null, 14 },
                    { 15, 1379, 1, false, false, 5, 15 },
                    { 16, 2556, 1, false, true, 3, 16 },
                    { 17, 1987, 1, false, false, null, 17 },
                    { 18, 9876, 1, false, true, 1, 18 },
                    { 19, 3837, 1, false, false, 5, 19 },
                    { 20, 4321, 1, false, false, null, 20 },
                    { 21, 5698, 1, false, false, 3, 21 },
                    { 22, 6067, 1, false, true, 5, 22 },
                    { 23, 7088, 1, false, false, 4, 23 },
                    { 24, 3219, 1, false, true, null, 24 },
                    { 25, 2198, 1, false, false, 4, 25 },
                    { 26, 8765, 1, false, true, null, 26 },
                    { 27, 7654, 1, false, false, 1, 27 },
                    { 28, 8594, 1, false, true, 4, 28 },
                    { 29, 5432, 1, false, false, null, 29 },
                    { 30, 9645, 1, false, false, 3, 30 },
                    { 31, 1034, 1, false, true, 5, 31 },
                    { 32, 6543, 1, false, false, 2, 32 },
                    { 33, 2345, 1, false, true, null, 33 },
                    { 34, 3456, 1, false, false, 2, 34 },
                    { 35, 2223, 1, false, false, 3, 35 },
                    { 36, 1543, 2, true, true, null, 36 },
                    { 37, 2804, 2, false, false, 7, 37 },
                    { 38, 3110, 2, false, true, 9, 38 },
                    { 39, 4975, 2, false, false, 10, 39 },
                    { 40, 5368, 2, false, true, 8, 40 },
                    { 41, 6729, 2, false, false, 9, 41 },
                    { 42, 7462, 2, false, false, 9, 42 },
                    { 43, 8901, 2, false, true, 6, 43 },
                    { 44, 9012, 2, false, false, 10, 44 },
                    { 45, 1098, 2, false, true, 6, 45 },
                    { 46, 2109, 2, false, false, 8, 46 },
                    { 47, 3210, 2, false, false, 6, 47 },
                    { 48, 8049, 2, false, true, 7, 48 },
                    { 49, 9127, 2, false, false, 7, 49 },
                    { 50, 1379, 2, false, true, 9, 50 },
                    { 51, 2556, 2, false, false, null, 51 },
                    { 52, 1987, 2, false, true, null, 52 },
                    { 53, 9876, 2, false, false, 10, 53 },
                    { 54, 3837, 2, false, false, 9, 54 },
                    { 55, 4321, 2, false, true, 9, 55 },
                    { 56, 5698, 2, false, false, 8, 56 },
                    { 57, 6067, 2, false, true, null, 57 },
                    { 58, 7088, 2, false, true, null, 58 },
                    { 59, 3219, 2, false, false, 6, 59 },
                    { 60, 2198, 2, false, true, 10, 60 },
                    { 61, 8765, 2, false, false, null, 61 },
                    { 62, 7654, 2, false, false, null, 62 },
                    { 63, 8594, 2, false, true, null, 63 },
                    { 64, 5432, 2, false, false, null, 64 },
                    { 65, 9645, 2, false, true, 7, 65 },
                    { 66, 1034, 2, false, true, 10, 66 },
                    { 67, 6543, 2, false, false, 10, 67 },
                    { 68, 2345, 2, false, true, 8, 68 },
                    { 69, 3456, 2, false, false, 6, 69 },
                    { 70, 2223, 2, false, false, null, 70 },
                    { 71, 2804, 3, true, true, null, 2 },
                    { 72, 4975, 3, false, false, 11, 4 },
                    { 73, 5368, 3, false, false, 12, 5 },
                    { 74, 6729, 3, false, true, null, 6 },
                    { 75, 8901, 3, false, true, null, 8 },
                    { 76, 1098, 3, false, false, null, 10 },
                    { 77, 3210, 3, false, true, 13, 12 },
                    { 78, 9127, 3, false, true, 14, 14 },
                    { 79, 1379, 3, false, true, null, 15 },
                    { 80, 1987, 3, false, false, null, 17 },
                    { 81, 3837, 3, false, false, null, 19 },
                    { 82, 4321, 3, false, true, null, 20 },
                    { 83, 5698, 3, false, false, 11, 21 },
                    { 84, 7088, 3, false, false, 13, 23 },
                    { 85, 2198, 3, false, true, 13, 25 },
                    { 86, 7654, 3, false, true, null, 27 },
                    { 87, 5432, 3, false, false, 14, 29 },
                    { 88, 9645, 3, false, false, null, 30 },
                    { 89, 6543, 3, false, false, 12, 32 },
                    { 90, 3456, 3, false, false, 12, 34 },
                    { 91, 2223, 3, false, false, 12, 35 },
                    { 92, 2804, 3, false, false, null, 37 },
                    { 93, 4975, 3, false, true, 13, 39 },
                    { 94, 6729, 3, false, false, 11, 41 },
                    { 95, 7462, 3, false, false, null, 42 },
                    { 96, 9012, 3, false, true, null, 44 },
                    { 97, 2109, 3, false, false, 11, 46 },
                    { 98, 3210, 3, false, false, 13, 47 },
                    { 99, 9127, 3, false, true, null, 49 },
                    { 100, 2556, 3, false, false, 13, 51 },
                    { 101, 9876, 3, false, false, null, 53 },
                    { 102, 3837, 3, false, true, 14, 54 },
                    { 103, 5698, 3, false, false, null, 56 },
                    { 104, 3219, 3, false, false, null, 59 },
                    { 105, 8765, 3, false, true, 11, 61 },
                    { 106, 7654, 3, false, false, null, 62 },
                    { 107, 5432, 3, false, true, 13, 64 },
                    { 108, 6543, 3, false, false, null, 67 },
                    { 109, 3456, 3, false, false, 14, 69 },
                    { 110, 2223, 3, false, true, 13, 70 },
                    { 111, 4975, 4, true, true, null, 4 },
                    { 112, 5368, 4, false, false, null, 5 },
                    { 113, 1098, 4, false, false, null, 10 },
                    { 114, 1987, 4, false, false, null, 17 },
                    { 115, 3837, 4, false, false, null, 19 },
                    { 116, 5698, 4, false, false, null, 21 },
                    { 117, 7088, 4, false, false, null, 23 },
                    { 118, 5432, 4, false, false, null, 29 },
                    { 119, 9645, 4, false, false, null, 30 },
                    { 120, 6543, 4, false, false, null, 32 },
                    { 121, 3456, 4, false, false, null, 34 },
                    { 122, 2223, 4, false, false, null, 35 },
                    { 123, 2804, 4, false, false, null, 37 },
                    { 124, 6729, 4, false, false, null, 41 },
                    { 125, 7462, 4, false, false, null, 42 },
                    { 126, 2109, 4, false, false, null, 46 },
                    { 127, 3210, 4, false, false, null, 47 },
                    { 128, 2556, 4, false, false, null, 51 },
                    { 129, 9876, 4, false, false, null, 53 },
                    { 130, 5698, 4, false, false, null, 56 },
                    { 131, 3219, 4, false, false, null, 59 },
                    { 132, 7654, 4, false, false, null, 62 },
                    { 133, 6543, 4, false, false, null, 67 },
                    { 134, 3456, 4, false, false, null, 69 }
                });

            migrationBuilder.InsertData(
                table: "Kills",
                columns: new[] { "Id", "DeadStory", "GameId", "KillerId", "TimeDead", "VictimId" },
                values: new object[,]
                {
                    { 1, "A lone human is hunted down and brutally killed by a ravenous zombie.", 1, 1, new DateTime(2023, 3, 11, 9, 10, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 2, "A lone human is hunted down and brutally killed by a ravenous zombie.", 1, 1, new DateTime(2023, 3, 11, 9, 23, 0, 0, DateTimeKind.Unspecified), 24 }
                });

            migrationBuilder.InsertData(
                table: "Missions",
                columns: new[] { "Id", "BeginTime", "Description", "EndTime", "HumanVisible", "Latitude", "Longitude", "MapId", "Title", "ZombieVisible" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), "Prepare for the upcoming Zombie attack.", new DateTime(2023, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 55.643242999999998, 12.270559, 1, "Get Supplies.", false },
                    { 2, new DateTime(2023, 3, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), "Reach the point.", new DateTime(2023, 3, 11, 10, 40, 0, 0, DateTimeKind.Unspecified), true, 55.643022000000002, 12.272587, 1, "Get fuel.", false },
                    { 3, new DateTime(2023, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Reach the point and hold it.", new DateTime(2023, 3, 11, 11, 5, 0, 0, DateTimeKind.Unspecified), true, 55.642327999999999, 12.272512000000001, 1, "Get Radio.", false },
                    { 4, new DateTime(2023, 3, 11, 11, 45, 0, 0, DateTimeKind.Unspecified), "Zombies shall capture the flag and the humans need to defend it.", new DateTime(2023, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 55.642780000000002, 12.271445, 1, "Stand Your Ground", true },
                    { 5, new DateTime(2023, 3, 12, 9, 30, 0, 0, DateTimeKind.Unspecified), "Prepare for the upcoming Zombie attack.", new DateTime(2023, 3, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 55.643242999999998, 12.270559, 2, "Get Supplies.", false },
                    { 6, new DateTime(2023, 3, 12, 10, 30, 0, 0, DateTimeKind.Unspecified), "Reach the point.", new DateTime(2023, 3, 12, 10, 40, 0, 0, DateTimeKind.Unspecified), true, 55.643022000000002, 12.272587, 2, "Get fuel.", false },
                    { 7, new DateTime(2023, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), "Reach the point and hold it.", new DateTime(2023, 3, 12, 11, 5, 0, 0, DateTimeKind.Unspecified), true, 55.642327999999999, 12.272512000000001, 2, "Get Radio.", false },
                    { 8, new DateTime(2023, 3, 12, 11, 45, 0, 0, DateTimeKind.Unspecified), "Zombies shall capture the flag and the humans need to defend it.", new DateTime(2023, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 55.642780000000002, 12.271445, 2, "Stand Your Ground", true },
                    { 9, new DateTime(2023, 3, 29, 9, 30, 0, 0, DateTimeKind.Unspecified), "Prepare for the upcoming Zombie attack.", new DateTime(2023, 3, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 55.643242999999998, 12.270559, 3, "Get Supplies.", false },
                    { 10, new DateTime(2023, 3, 29, 10, 30, 0, 0, DateTimeKind.Unspecified), "Reach the point.", new DateTime(2023, 3, 29, 10, 40, 0, 0, DateTimeKind.Unspecified), true, 55.643022000000002, 12.272587, 3, "Get fuel.", false },
                    { 11, new DateTime(2023, 3, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), "Reach the point and hold it.", new DateTime(2023, 3, 29, 11, 5, 0, 0, DateTimeKind.Unspecified), true, 55.642327999999999, 12.272512000000001, 3, "Get Radio.", false },
                    { 12, new DateTime(2023, 3, 29, 11, 45, 0, 0, DateTimeKind.Unspecified), "Zombies shall capture the flag and the humans need to defend it.", new DateTime(2023, 3, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 55.642780000000002, 12.271445, 3, "Stand Your Ground", true },
                    { 13, new DateTime(2023, 3, 31, 9, 30, 0, 0, DateTimeKind.Unspecified), "Prepare for the upcoming Zombie attack.", new DateTime(2023, 3, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 55.643242999999998, 12.270559, 4, "Get Supplies.", false },
                    { 14, new DateTime(2023, 3, 31, 10, 30, 0, 0, DateTimeKind.Unspecified), "Reach the point.", new DateTime(2023, 3, 31, 10, 40, 0, 0, DateTimeKind.Unspecified), true, 55.643022000000002, 12.272587, 4, "Get fuel.", false },
                    { 15, new DateTime(2023, 3, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), "Reach the point and hold it.", new DateTime(2023, 3, 31, 11, 5, 0, 0, DateTimeKind.Unspecified), true, 55.642327999999999, 12.272512000000001, 4, "Get Radio.", false },
                    { 16, new DateTime(2023, 3, 31, 11, 45, 0, 0, DateTimeKind.Unspecified), "Zombies shall capture the flag and the humans need to defend it.", new DateTime(2023, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 55.642780000000002, 12.271445, 4, "Stand Your Ground", true }
                });

            migrationBuilder.InsertData(
                table: "Safezones",
                columns: new[] { "Id", "BeginTime", "Description", "EndTime", "HumanVisible", "Latitude", "Longitude", "MapId", "Radius", "Title", "ZombieVisible" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "Permanant Safezone for Humans", new DateTime(2023, 3, 11, 11, 45, 0, 0, DateTimeKind.Unspecified), true, 55.642780000000002, 12.271445, 1, 10, "Human HQ", true },
                    { 2, new DateTime(2023, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), "Permanant Safezone for Humans", new DateTime(2023, 3, 12, 11, 45, 0, 0, DateTimeKind.Unspecified), true, 55.642780000000002, 12.271445, 2, 10, "Human HQ", true },
                    { 3, new DateTime(2023, 3, 29, 9, 0, 0, 0, DateTimeKind.Unspecified), "Permanant Safezone for Humans", new DateTime(2023, 3, 29, 11, 45, 0, 0, DateTimeKind.Unspecified), true, 55.642780000000002, 12.271445, 3, 10, "Human HQ", true },
                    { 4, new DateTime(2023, 3, 31, 9, 0, 0, 0, DateTimeKind.Unspecified), "Permanant Safezone for Humans", new DateTime(2023, 3, 31, 11, 45, 0, 0, DateTimeKind.Unspecified), true, 55.642780000000002, 12.271445, 4, 10, "Human HQ", true }
                });

            migrationBuilder.InsertData(
                table: "Supplies",
                columns: new[] { "Id", "Amount", "BeginTime", "Description", "Drop", "EndTime", "HumanVisible", "Latitude", "Longitude", "MapId", "Title", "ZombieVisible" },
                values: new object[,]
                {
                    { 1, 40, new DateTime(2023, 3, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2023, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 55.643242999999998, 12.270559, 1, "NerfGun Ammo", false },
                    { 2, 10, new DateTime(2023, 3, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2023, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 55.643242999999998, 12.270559, 1, "NerfGun", false },
                    { 3, 10, new DateTime(2023, 3, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), null, 0, new DateTime(2023, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 55.643242999999998, 12.270559, 1, "Grenades", false },
                    { 4, 40, new DateTime(2023, 3, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2023, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 55.643242999999998, 12.270559, 2, "NerfGun Ammo", false },
                    { 5, 10, new DateTime(2023, 3, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2023, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 55.643242999999998, 12.270559, 2, "NerfGun", false },
                    { 6, 10, new DateTime(2023, 3, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), null, 0, new DateTime(2023, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 55.643242999999998, 12.270559, 2, "Grenades", false },
                    { 7, 40, new DateTime(2023, 3, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2023, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 55.643242999999998, 12.270559, 3, "NerfGun Ammo", false },
                    { 8, 10, new DateTime(2023, 3, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2023, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 55.643242999999998, 12.270559, 3, "NerfGun", false },
                    { 9, 10, new DateTime(2023, 3, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), null, 0, new DateTime(2023, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 55.643242999999998, 12.270559, 3, "Grenades", false },
                    { 10, 40, new DateTime(2023, 3, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2023, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 55.643242999999998, 12.270559, 4, "NerfGun Ammo", false },
                    { 11, 10, new DateTime(2023, 3, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2023, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 55.643242999999998, 12.270559, 4, "NerfGun", false },
                    { 12, 10, new DateTime(2023, 3, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), null, 0, new DateTime(2023, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 55.643242999999998, 12.270559, 4, "Grenades", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chats_GameId",
                table: "Chats",
                column: "GameId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chats_PlayerId",
                table: "Chats",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_AdminId",
                table: "Games",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Kills_GameId",
                table: "Kills",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Kills_KillerId",
                table: "Kills",
                column: "KillerId");

            migrationBuilder.CreateIndex(
                name: "IX_Kills_VictimId",
                table: "Kills",
                column: "VictimId");

            migrationBuilder.CreateIndex(
                name: "IX_Maps_GameId",
                table: "Maps",
                column: "GameId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Missions_MapId",
                table: "Missions",
                column: "MapId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_GameId",
                table: "Players",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_SquadId",
                table: "Players",
                column: "SquadId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_UserId",
                table: "Players",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Safezones_MapId",
                table: "Safezones",
                column: "MapId");

            migrationBuilder.CreateIndex(
                name: "IX_Squads_GameId",
                table: "Squads",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Supplies_MapId",
                table: "Supplies",
                column: "MapId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Kills");

            migrationBuilder.DropTable(
                name: "Missions");

            migrationBuilder.DropTable(
                name: "Safezones");

            migrationBuilder.DropTable(
                name: "Supplies");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Maps");

            migrationBuilder.DropTable(
                name: "Squads");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Admins");
        }
    }
}
