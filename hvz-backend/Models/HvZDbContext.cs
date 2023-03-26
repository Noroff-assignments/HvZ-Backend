using hvz_backend.Models.Enums;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Extensions;

namespace hvz_backend.Models
{
    public class HvZDbContext : DbContext
    {
        // Sets the tables for the database
        public DbSet<Game> Games { get; set; }
        public DbSet<Kill> Kills { get; set; }

        public DbSet<Map> Maps { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Safezone> Safezones { get; set; }
        public DbSet<Squad> Squads { get; set; }
        public DbSet<Supply> Supplies { get; set; }


        public HvZDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region Games
            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    Id = 1,
                    AdminID = "a4b0e985-cdb0-4752-ba07-1ee7334d3391",
                    BeginTime = new DateTime(2023, 03, 11, 09, 00, 00),
                    EndTime = new DateTime(2023, 03, 11, 12, 00, 00),
                    Status = StateGame.Completed,
                    MapId = 1,
                    Title = "Humans vs. Zombies - Experis Academy Championship (Qualification 1).",
                    Description = "Welcome to the Experis Academy Championship Qualification 1 for Human vs Zombie, " +
                    "the ultimate battle between humanity and the undead. The stage is set, and the contestants are ready " +
                    "to face their fears and fight for survival. As the game begins, the human players are armed with weapons such as guns and grenades " +
                    "while the zombie players rely on their brute strength and contagious bites to infect the human players." +
                    "The objective of the game is simple. The human players must survive the zombie invasion, while the zombie players must infect all the human players before time runs out. " +
                    "The players must constantly strategize and adapt to the changing game dynamics, find supplies, safezones and clear missions. As the game progress, " +
                    "the game becomes more challenging, and the players must use all their skills and resources to stay alive. " +
                    "The human players must be quick on their feet and accurate with their weapons, while the zombie players must be relentless and work together to corner their prey." +
                    "The Experis Academy candidates are some of the most talented and skilled players in the game, and the championship promises to be an exciting showcase of their abilities. " +
                    "Who will emerge victorious, the humans or the zombies? Only time will tell. Join us as we witness the ultimate battle between life and death, in the Experis Academy Championship for Human vs Zombie."
                },
                new Game
                {
                    Id = 2,
                    AdminID = "a4b0e985-cdb0-4752-ba07-1ee7334d3391",
                    BeginTime = new DateTime(2023, 03, 12, 09, 00, 00),
                    EndTime = new DateTime(2023, 03, 12, 12, 00, 00),
                    Status = StateGame.Completed,
                    MapId = 2,
                    Title = "Humans vs. Zombies - Experis Academy Championship (Qualification 2).",
                    Description = "Welcome to the Experis Academy Championship Qualification 2 for Human vs Zombie, " +
                    "the ultimate battle between humanity and the undead. The stage is set, and the contestants are ready " +
                    "to face their fears and fight for survival. As the game begins, the human players are armed with weapons such as guns and grenades " +
                    "while the zombie players rely on their brute strength and contagious bites to infect the human players." +
                    "The objective of the game is simple. The human players must survive the zombie invasion, while the zombie players must infect all the human players before time runs out. " +
                    "The players must constantly strategize and adapt to the changing game dynamics, find supplies, safezones and clear missions. As the game progress, " +
                    "the game becomes more challenging, and the players must use all their skills and resources to stay alive. " +
                    "The human players must be quick on their feet and accurate with their weapons, while the zombie players must be relentless and work together to corner their prey." +
                    "The Experis Academy candidates are some of the most talented and skilled players in the game, and the championship promises to be an exciting showcase of their abilities. " +
                    "Who will emerge victorious, the humans or the zombies? Only time will tell. Join us as we witness the ultimate battle between life and death, in the Experis Academy Championship for Human vs Zombie."
                },
                new Game
                {
                    Id = 3,
                    AdminID = "f4553ac1-daa8-4064-841c-a5f5e107c336",
                    BeginTime = new DateTime(2023, 03, 29, 09, 00, 00),
                    EndTime = new DateTime(2023, 03, 29, 12, 00, 00),
                    Status = StateGame.Running,
                    MapId = 3,
                    Title = "Humans vs. Zombies - Experis Academy Championship - Semifinals.",
                    Description = "Welcome to the Experis Academy Championship Semifinals for Human vs Zombie, " +
                    "the ultimate battle between humanity and the undead. The stage is set, and the contestants are ready " +
                    "to face their fears and fight for survival. As the game begins, the human players are armed with weapons such as guns and grenades " +
                    "while the zombie players rely on their brute strength and contagious bites to infect the human players." +
                    "The objective of the game is simple. The human players must survive the zombie invasion, while the zombie players must infect all the human players before time runs out. " +
                    "The players must constantly strategize and adapt to the changing game dynamics, find supplies, safezones and clear missions. As the game progress, " +
                    "the game becomes more challenging, and the players must use all their skills and resources to stay alive. " +
                    "The human players must be quick on their feet and accurate with their weapons, while the zombie players must be relentless and work together to corner their prey." +
                    "The Experis Academy candidates are some of the most talented and skilled players in the game, and the championship promises to be an exciting showcase of their abilities. " +
                    "Who will emerge victorious, the humans or the zombies? Only time will tell. Join us as we witness the ultimate battle between life and death, in the Experis Academy Championship for Human vs Zombie."
                },
                new Game
                {
                    Id = 4,
                    AdminID = "a2cba5cb-667b-4566-a367-a1c62e7b8fd5",
                    BeginTime = new DateTime(2023, 03, 31, 09, 00, 00),
                    EndTime = new DateTime(2023, 03, 31, 12, 00, 00),
                    Status = StateGame.Registrating,
                    MapId = 4,
                    Title = "Humans vs. Zombies - Experis Academy Championship - finals.",
                    Description = "Welcome to the Experis Academy Championship finals for Human vs Zombie, " +
                    "the ultimate battle between humanity and the undead. The stage is set, and the contestants are ready " +
                    "to face their fears and fight for survival. As the game begins, the human players are armed with weapons such as guns and grenades " +
                    "while the zombie players rely on their brute strength and contagious bites to infect the human players." +
                    "The objective of the game is simple. The human players must survive the zombie invasion, while the zombie players must infect all the human players before time runs out. " +
                    "The players must constantly strategize and adapt to the changing game dynamics, find supplies, safezones and clear missions. As the game progress, " +
                    "the game becomes more challenging, and the players must use all their skills and resources to stay alive. " +
                    "The human players must be quick on their feet and accurate with their weapons, while the zombie players must be relentless and work together to corner their prey." +
                    "The Experis Academy candidates are some of the most talented and skilled players in the game, and the championship promises to be an exciting showcase of their abilities. " +
                    "Who will emerge victorious, the humans or the zombies? Only time will tell. Join us as we witness the ultimate battle between life and death, in the Experis Academy Championship for Human vs Zombie."
                }
                );
            modelBuilder.Entity<Game>()
                .HasMany(g => g.Kills)
                .WithOne(k => k.Game)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Game>()
                .HasMany(g => g.Players)
                .WithOne(p => p.Game)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Game>()
                .HasMany(g => g.Squads)
                .WithOne(s => s.Game)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region Kills

            modelBuilder.Entity<Kill>()
            .HasOne(k => k.Killer)
            .WithMany(p => p.KillsByMe)
            .HasForeignKey(k => k.KillerId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Kill>()
                .HasOne(k => k.Victim)
                .WithMany(p => p.KillsAgainstMe)
                .HasForeignKey(k => k.VictimId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Kill>().HasData(
                new Kill { Id = 1, GameId = 1, KillerId = 1, VictimId = 18, TimeDead = new DateTime(2023, 03, 11, 09, 10, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 2, GameId = 1, KillerId = 1, VictimId = 24, TimeDead = new DateTime(2023, 03, 11, 09, 23, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 3, GameId = 1, KillerId = 18, VictimId = 3, TimeDead = new DateTime(2023, 03, 11, 09, 43, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 4, GameId = 1, KillerId = 24, VictimId = 9, TimeDead = new DateTime(2023, 03, 11, 09, 55, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 5, GameId = 1, KillerId = 1, VictimId = 7, TimeDead = new DateTime(2023, 03, 11, 10, 10, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 6, GameId = 1, KillerId = 3, VictimId = 33, TimeDead = new DateTime(2023, 03, 11, 10, 16, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 7, GameId = 1, KillerId = 3, VictimId = 13, TimeDead = new DateTime(2023, 03, 11, 10, 33, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 8, GameId = 1, KillerId = 7, VictimId = 11, TimeDead = new DateTime(2023, 03, 11, 10, 47, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 9, GameId = 1, KillerId = 9, VictimId = 16, TimeDead = new DateTime(2023, 03, 11, 10, 56, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 10, GameId = 1, KillerId = 1, VictimId = 22, TimeDead = new DateTime(2023, 03, 11, 11, 17, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 11, GameId = 1, KillerId = 18, VictimId = 24, TimeDead = new DateTime(2023, 03, 11, 11, 22, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 12, GameId = 1, KillerId = 16, VictimId = 31, TimeDead = new DateTime(2023, 03, 11, 11, 38, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 13, GameId = 1, KillerId = 11, VictimId = 26, TimeDead = new DateTime(2023, 03, 11, 11, 49, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 14, GameId = 1, KillerId = 13, VictimId = 28, TimeDead = new DateTime(2023, 03, 11, 11, 51, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 15, GameId = 2, KillerId = 36, VictimId = 66, TimeDead = new DateTime(2023, 03, 12, 09, 19, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 16, GameId = 2, KillerId = 36, VictimId = 55, TimeDead = new DateTime(2023, 03, 12, 09, 32, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 17, GameId = 2, KillerId = 55, VictimId = 50, TimeDead = new DateTime(2023, 03, 12, 09, 44, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 18, GameId = 2, KillerId = 66, VictimId = 38, TimeDead = new DateTime(2023, 03, 12, 09, 58, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 19, GameId = 2, KillerId = 38, VictimId = 40, TimeDead = new DateTime(2023, 03, 12, 10, 16, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 20, GameId = 2, KillerId = 50, VictimId = 68, TimeDead = new DateTime(2023, 03, 12, 10, 23, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 21, GameId = 2, KillerId = 36, VictimId = 43, TimeDead = new DateTime(2023, 03, 12, 10, 47, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 22, GameId = 2, KillerId = 66, VictimId = 52, TimeDead = new DateTime(2023, 03, 12, 10, 50, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 23, GameId = 2, KillerId = 68, VictimId = 60, TimeDead = new DateTime(2023, 03, 12, 11, 07, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 24, GameId = 2, KillerId = 40, VictimId = 48, TimeDead = new DateTime(2023, 03, 12, 11, 27, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 25, GameId = 2, KillerId = 60, VictimId = 65, TimeDead = new DateTime(2023, 03, 12, 11, 33, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 26, GameId = 2, KillerId = 50, VictimId = 57, TimeDead = new DateTime(2023, 03, 12, 11, 41, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 27, GameId = 2, KillerId = 40, VictimId = 58, TimeDead = new DateTime(2023, 03, 12, 11, 44, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 28, GameId = 2, KillerId = 68, VictimId = 45, TimeDead = new DateTime(2023, 03, 12, 11, 45, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 29, GameId = 2, KillerId = 57, VictimId = 63, TimeDead = new DateTime(2023, 03, 12, 11, 52, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 30, GameId = 3, KillerId = 2, VictimId = 12, TimeDead = new DateTime(2023, 03, 29, 09, 13, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 31, GameId = 3, KillerId = 2, VictimId = 15, TimeDead = new DateTime(2023, 03, 29, 09, 24, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 32, GameId = 3, KillerId = 12, VictimId = 20, TimeDead = new DateTime(2023, 03, 29, 09, 39, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 33, GameId = 3, KillerId = 2, VictimId = 25, TimeDead = new DateTime(2023, 03, 29, 09, 55, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 34, GameId = 3, KillerId = 15, VictimId = 8, TimeDead = new DateTime(2023, 03, 29, 10, 07, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 35, GameId = 3, KillerId = 20, VictimId = 44, TimeDead = new DateTime(2023, 03, 29, 10, 15, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 36, GameId = 3, KillerId = 25, VictimId = 70, TimeDead = new DateTime(2023, 03, 29, 10, 20, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 37, GameId = 3, KillerId = 2, VictimId = 64, TimeDead = new DateTime(2023, 03, 29, 10, 35, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 38, GameId = 3, KillerId = 8, VictimId = 49, TimeDead = new DateTime(2023, 03, 29, 10, 40, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 39, GameId = 3, KillerId = 15, VictimId = 6, TimeDead = new DateTime(2023, 03, 29, 10, 47, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 40, GameId = 3, KillerId = 44, VictimId = 39, TimeDead = new DateTime(2023, 03, 29, 11, 02, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 41, GameId = 3, KillerId = 70, VictimId = 27, TimeDead = new DateTime(2023, 03, 29, 11, 16, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 42, GameId = 3, KillerId = 64, VictimId = 14, TimeDead = new DateTime(2023, 03, 29, 11, 24, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 43, GameId = 3, KillerId = 6, VictimId = 61, TimeDead = new DateTime(2023, 03, 29, 11, 41, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 44, GameId = 3, KillerId = 27, VictimId = 54, TimeDead = new DateTime(2023, 03, 29, 11, 49, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." }
                );

            #endregion

            #region Maps
            modelBuilder.Entity<Map>().HasData(
                new Map { Id = 1, Latitude = 55.642780, Longitude = 12.271445, MapName = "Experis Academy Denmark", MapDescription = "The location for the Experis Academy World Championship 2023.", Radius = 100 },
                new Map { Id = 2, Latitude = 55.642780, Longitude = 12.271445, MapName = "Experis Academy Denmark", MapDescription = "The location for the Experis Academy World Championship 2023.", Radius = 100 },
                new Map { Id = 3, Latitude = 55.642780, Longitude = 12.271445, MapName = "Experis Academy Denmark", MapDescription = "The location for the Experis Academy World Championship 2023.", Radius = 100 },
                new Map { Id = 4, Latitude = 55.642780, Longitude = 12.271445, MapName = "Experis Academy Denmark", MapDescription = "The location for the Experis Academy World Championship 2023.", Radius = 100 }
                );
            modelBuilder.Entity<Map>()
                .HasMany(m => m.Missions)
                .WithOne(m => m.Map)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Map>()
                .HasMany(m => m.Safezones)
                .WithOne(m => m.Map)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Map>()
                .HasMany(m => m.Supplies)
                .WithOne(m => m.Map)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region Missions
            modelBuilder.Entity<Mission>().HasData(
                new Mission { Id = 1, Title = "Get Supplies.", HumanVisible = true, ZombieVisible = false, MapId = 1, Description = "Prepare for the upcoming Zombie attack.", BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Radius = 10 },
                new Mission { Id = 2, Title = "Get fuel.", HumanVisible = true, ZombieVisible = false, MapId = 1, Description = "Reach the point.", BeginTime = new DateTime(2023, 03, 11, 10, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 40, 00), Latitude = 55.643022, Longitude = 12.272587, Radius = 10 },
                new Mission { Id = 3, Title = "Get Radio.", HumanVisible = true, ZombieVisible = false, MapId = 1, Description = "Reach the point and hold it.", BeginTime = new DateTime(2023, 03, 11, 11, 00, 00), EndTime = new DateTime(2023, 03, 11, 11, 05, 00), Latitude = 55.642328, Longitude = 12.272512, Radius = 10 },
                new Mission { Id = 4, Title = "Stand Your Ground", HumanVisible = true, ZombieVisible = true, MapId = 1, Description = "Zombies shall capture the flag and the humans need to defend it.", BeginTime = new DateTime(2023, 03, 11, 11, 45, 00), EndTime = new DateTime(2023, 03, 11, 12, 00, 00), Latitude = 55.642780, Longitude = 12.271445, Radius = 10 },

                new Mission { Id = 5, Title = "Get Supplies.", HumanVisible = true, ZombieVisible = false, MapId = 2, Description = "Prepare for the upcoming Zombie attack.", BeginTime = new DateTime(2023, 03, 12, 09, 30, 00), EndTime = new DateTime(2023, 03, 12, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Radius = 10 },
                new Mission { Id = 6, Title = "Get fuel.", HumanVisible = true, ZombieVisible = false, MapId = 2, Description = "Reach the point.", BeginTime = new DateTime(2023, 03, 12, 10, 30, 00), EndTime = new DateTime(2023, 03, 12, 10, 40, 00), Latitude = 55.643022, Longitude = 12.272587, Radius = 10 },
                new Mission { Id = 7, Title = "Get Radio.", HumanVisible = true, ZombieVisible = false, MapId = 2, Description = "Reach the point and hold it.", BeginTime = new DateTime(2023, 03, 12, 11, 00, 00), EndTime = new DateTime(2023, 03, 12, 11, 05, 00), Latitude = 55.642328, Longitude = 12.272512, Radius = 10 },
                new Mission { Id = 8, Title = "Stand Your Ground", HumanVisible = true, ZombieVisible = true, MapId = 2, Description = "Zombies shall capture the flag and the humans need to defend it.", BeginTime = new DateTime(2023, 03, 12, 11, 45, 00), EndTime = new DateTime(2023, 03, 12, 12, 00, 00), Latitude = 55.642780, Longitude = 12.271445, Radius = 10 },

                new Mission { Id = 9, Title = "Get Supplies.", HumanVisible = true, ZombieVisible = false, MapId = 3, Description = "Prepare for the upcoming Zombie attack.", BeginTime = new DateTime(2023, 03, 29, 09, 30, 00), EndTime = new DateTime(2023, 03, 29, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Radius = 10 },
                new Mission { Id = 10, Title = "Get fuel.", HumanVisible = true, ZombieVisible = false, MapId = 3, Description = "Reach the point.", BeginTime = new DateTime(2023, 03, 29, 10, 30, 00), EndTime = new DateTime(2023, 03, 29, 10, 40, 00), Latitude = 55.643022, Longitude = 12.272587, Radius = 10 },
                new Mission { Id = 11, Title = "Get Radio.", HumanVisible = true, ZombieVisible = false, MapId = 3, Description = "Reach the point and hold it.", BeginTime = new DateTime(2023, 03, 29, 11, 00, 00), EndTime = new DateTime(2023, 03, 29, 11, 05, 00), Latitude = 55.642328, Longitude = 12.272512, Radius = 10 },
                new Mission { Id = 12, Title = "Stand Your Ground", HumanVisible = true, ZombieVisible = true, MapId = 3, Description = "Zombies shall capture the flag and the humans need to defend it.", BeginTime = new DateTime(2023, 03, 29, 11, 45, 00), EndTime = new DateTime(2023, 03, 29, 12, 00, 00), Latitude = 55.642780, Longitude = 12.271445, Radius = 10 },

                new Mission { Id = 13, Title = "Get Supplies.", HumanVisible = true, ZombieVisible = false, MapId = 4, Description = "Prepare for the upcoming Zombie attack.", BeginTime = new DateTime(2023, 03, 31, 09, 30, 00), EndTime = new DateTime(2023, 03, 31, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Radius = 10 },
                new Mission { Id = 14, Title = "Get fuel.", HumanVisible = true, ZombieVisible = false, MapId = 4, Description = "Reach the point.", BeginTime = new DateTime(2023, 03, 31, 10, 30, 00), EndTime = new DateTime(2023, 03, 31, 10, 40, 00), Latitude = 55.643022, Longitude = 12.272587, Radius = 10 },
                new Mission { Id = 15, Title = "Get Radio.", HumanVisible = true, ZombieVisible = false, MapId = 4, Description = "Reach the point and hold it.", BeginTime = new DateTime(2023, 03, 31, 11, 00, 00), EndTime = new DateTime(2023, 03, 31, 11, 05, 00), Latitude = 55.642328, Longitude = 12.272512, Radius = 10 },
                new Mission { Id = 16, Title = "Stand Your Ground", HumanVisible = true, ZombieVisible = true, MapId = 4, Description = "Zombies shall capture the flag and the humans need to defend it.", BeginTime = new DateTime(2023, 03, 31, 11, 45, 00), EndTime = new DateTime(2023, 03, 31, 12, 00, 00), Latitude = 55.642780, Longitude = 12.271445, Radius = 10 }
                );
            #endregion


            #region Players
            modelBuilder.Entity<Player>().HasData(
                new Player { Id = 1, Latitude = 55.642780, Longitude = 12.271445, UserID = "acc85530-f88c-4de6-86e2-083bc5f86641", SquadId = null, IsPatientZero = true, IsZombie = true, BiteCode = 1543, GameId = 1 },
                new Player { Id = 2, Latitude = 55.642780, Longitude = 12.271445, UserID = "d19c226a-22fb-4e6f-81a4-c1d153f929b7", SquadId = 2, IsPatientZero = false, IsZombie = false, BiteCode = 2804, GameId = 1 },
                new Player { Id = 3, Latitude = 55.642780, Longitude = 12.271445, UserID = "40885ab0-a5bb-4d76-a5d5-5db34156912b", SquadId = 2, IsPatientZero = false, IsZombie = true, BiteCode = 3110, GameId = 1 },
                new Player { Id = 4, Latitude = 55.642780, Longitude = 12.271445, UserID = "70a4f7b8-a619-438f-b309-fd333a9e8577", SquadId = 3, IsPatientZero = false, IsZombie = false, BiteCode = 4975, GameId = 1 },
                new Player { Id = 5, Latitude = 55.642780, Longitude = 12.271445, UserID = "1861c804-6669-49bb-b35b-5b2c191b850c", SquadId = 3, IsPatientZero = false, IsZombie = false, BiteCode = 5368, GameId = 1 },
                new Player { Id = 6, Latitude = 55.642780, Longitude = 12.271445, UserID = "245b9d79-0aa1-435d-9878-4896744f221b", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 6729, GameId = 1 },
                new Player { Id = 7, Latitude = 55.642780, Longitude = 12.271445, UserID = "25b14121-60e7-4126-9926-34ccefc08ec2", SquadId = 4, IsPatientZero = false, IsZombie = true, BiteCode = 7462, GameId = 1 },
                new Player { Id = 8, Latitude = 55.642780, Longitude = 12.271445, UserID = "f52236fb-2ab2-4345-bfe5-bfa82b776cf1", SquadId = 2, IsPatientZero = false, IsZombie = false, BiteCode = 8901, GameId = 1 },
                new Player { Id = 9, Latitude = 55.642780, Longitude = 12.271445, UserID = "1e660e8f-893c-4224-82af-8f80d332d4a6", SquadId = 1, IsPatientZero = false, IsZombie = true, BiteCode = 9012, GameId = 1 },
                new Player { Id = 10,Latitude = 55.642780, Longitude = 12.271445, UserID = "fb55b851-bfeb-4781-8e8a-bc2af03fea63", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 1098, GameId = 1 },
                new Player { Id = 11,Latitude = 55.642780, Longitude = 12.271445, UserID = "f8c97264f-0c1b-4dca-9cc3-fe786f8f0962", SquadId = null, IsPatientZero = false, IsZombie = true, BiteCode = 2109, GameId = 1 },
                new Player { Id = 12,Latitude = 55.642780, Longitude = 12.271445, UserID = "203837e7-29b9-400f-bdd8-5094abb4f3ab", SquadId = 2, IsPatientZero = false, IsZombie = false, BiteCode = 3210, GameId = 1 },
                new Player { Id = 13,Latitude = 55.642780, Longitude = 12.271445, UserID = "f0ecd9f5-ee43-4fbf-bc01-7a6f6d6e52a2", SquadId = 4, IsPatientZero = false, IsZombie = true, BiteCode = 8049, GameId = 1 },
                new Player { Id = 14,Latitude = 55.642780, Longitude = 12.271445, UserID = "1ca26c1d-7737-44aa-abc3-4120d1e84cde", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 9127, GameId = 1 },
                new Player { Id = 15,Latitude = 55.642780, Longitude = 12.271445, UserID = "87e22096-fce7-413d-a9e7-1ae785ef39ac", SquadId = 5, IsPatientZero = false, IsZombie = false, BiteCode = 1379, GameId = 1 },
                new Player { Id = 16,Latitude = 55.642780, Longitude = 12.271445, UserID = "da02dda1-0510-4f20-8cd7-1e22c6e4321e", SquadId = 3, IsPatientZero = false, IsZombie = true, BiteCode = 2556, GameId = 1 },
                new Player { Id = 17,Latitude = 55.642780, Longitude = 12.271445, UserID = "61bb9ef9-9f9e-4ce5-b466-4add87940ed8", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 1987, GameId = 1 },
                new Player { Id = 18,Latitude = 55.642780, Longitude = 12.271445, UserID = "ed860bdc-50ff-4637-81c2-af42cba90f54", SquadId = 1, IsPatientZero = false, IsZombie = true, BiteCode = 9876, GameId = 1 },
                new Player { Id = 19,Latitude = 55.642780, Longitude = 12.271445, UserID = "db7df012-1f85-44f4-a6b8-6bf95bc9b715", SquadId = 5, IsPatientZero = false, IsZombie = false, BiteCode = 3837, GameId = 1 },
                new Player { Id = 20,Latitude = 55.642780, Longitude = 12.271445, UserID = "d676b8d0-8353-4e0e-900c-335719b031eb", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 4321, GameId = 1 },
                new Player { Id = 21,Latitude = 55.642780, Longitude = 12.271445, UserID = "7c303786-36f5-410d-bae1-8fbcb92c6603", SquadId = 3, IsPatientZero = false, IsZombie = false, BiteCode = 5698, GameId = 1 },
                new Player { Id = 22,Latitude = 55.642780, Longitude = 12.271445, UserID = "1d270eb6-53bf-440b-8eb9-c71feedf49dd", SquadId = 5, IsPatientZero = false, IsZombie = true, BiteCode = 6067, GameId = 1 },
                new Player { Id = 23,Latitude = 55.642780, Longitude = 12.271445, UserID = "ba89254d-974f-4d64-abe8-8c2ddeabc1b7", SquadId = 4, IsPatientZero = false, IsZombie = false, BiteCode = 7088, GameId = 1 },
                new Player { Id = 24,Latitude = 55.642780, Longitude = 12.271445, UserID = "49c024eb-d205-4587-bfd6-e5dbfb1702f3", SquadId = null, IsPatientZero = false, IsZombie = true, BiteCode = 3219, GameId = 1 },
                new Player { Id = 25,Latitude = 55.642780, Longitude = 12.271445, UserID = "43f44f34-5ee1-4b80-95c2-0cf2c2cb0776", SquadId = 4, IsPatientZero = false, IsZombie = false, BiteCode = 2198, GameId = 1 },
                new Player { Id = 26,Latitude = 55.642780, Longitude = 12.271445, UserID = "b25e5332-0308-4e1c-b137-dae33588ea6c", SquadId = null, IsPatientZero = false, IsZombie = true, BiteCode = 8765, GameId = 1 },
                new Player { Id = 27,Latitude = 55.642780, Longitude = 12.271445, UserID = "0920e3c1-f978-4b70-a7f5-9c766595b475", SquadId = 1, IsPatientZero = false, IsZombie = false, BiteCode = 7654, GameId = 1 },
                new Player { Id = 28,Latitude = 55.642780, Longitude = 12.271445, UserID = "7b6371fd-a26f-41b0-9056-c793ff7e07d6", SquadId = 4, IsPatientZero = false, IsZombie = true, BiteCode = 8594, GameId = 1 },
                new Player { Id = 29,Latitude = 55.642780, Longitude = 12.271445, UserID = "6251cd7b-0a79-49e6-b4f2-b153bf21ac97", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 5432, GameId = 1 },
                new Player { Id = 30,Latitude = 55.642780, Longitude = 12.271445, UserID = "a56481e5-9c6a-4aef-9e07-c534a33f0097", SquadId = 3, IsPatientZero = false, IsZombie = false, BiteCode = 9645, GameId = 1 },
                new Player { Id = 31,Latitude = 55.642780, Longitude = 12.271445, UserID = "2454c85a-b5b1-4c08-b265-e8e5a7ced4b7", SquadId = 5, IsPatientZero = false, IsZombie = true, BiteCode = 1034, GameId = 1 },
                new Player { Id = 32,Latitude = 55.642780, Longitude = 12.271445, UserID = "10db85db-9750-415f-b6f3-333bdd678758", SquadId = 2, IsPatientZero = false, IsZombie = false, BiteCode = 6543, GameId = 1 },
                new Player { Id = 33,Latitude = 55.642780, Longitude = 12.271445, UserID = "e386781a-bda7-4dba-a504-10999ed91267", SquadId = null, IsPatientZero = false, IsZombie = true, BiteCode = 2345, GameId = 1 },
                new Player { Id = 34,Latitude = 55.642780, Longitude = 12.271445, UserID = "01731ab5-8f28-4a7b-afe7-c892fc5bd8d9", SquadId = 2, IsPatientZero = false, IsZombie = false, BiteCode = 3456, GameId = 1 },
                new Player { Id = 35,Latitude = 55.642780, Longitude = 12.271445, UserID = "a7551a99-7573-4abc-afae-b7186d35fb5a", SquadId = 3, IsPatientZero = false, IsZombie = false, BiteCode = 2223, GameId = 1 },
                                    
                new Player { Id = 36,Latitude = 55.642780, Longitude = 12.271445, UserID = "542189b8-9df5-41d4-aece-5bff052a53f9", SquadId = null, IsPatientZero = true, IsZombie = true, BiteCode = 1543, GameId = 2 },
                new Player { Id = 37,Latitude = 55.642780, Longitude = 12.271445, UserID = "bbf55298-5e22-49a3-945c-b4d79346a3ed", SquadId = 7, IsPatientZero = false, IsZombie = false, BiteCode = 2804, GameId = 2 },
                new Player { Id = 38,Latitude = 55.642780, Longitude = 12.271445, UserID = "dba845f7-fd61-4f1a-b8a6-4c67de2e8612", SquadId = 9, IsPatientZero = false, IsZombie = true, BiteCode = 3110, GameId = 2 },
                new Player { Id = 39,Latitude = 55.642780, Longitude = 12.271445, UserID = "02e94a01-3d77-477f-8598-a87a0a91ea1a", SquadId = 10, IsPatientZero = false, IsZombie = false, BiteCode = 4975, GameId = 2 },
                new Player { Id = 40,Latitude = 55.642780, Longitude = 12.271445, UserID = "430d1e90-27d9-47ca-afa9-8f6c41d1e272", SquadId = 8, IsPatientZero = false, IsZombie = true, BiteCode = 5368, GameId = 2 },
                new Player { Id = 41,Latitude = 55.642780, Longitude = 12.271445, UserID = "7596aaf8-c8a6-449a-be88-e2e0263e51de", SquadId = 9, IsPatientZero = false, IsZombie = false, BiteCode = 6729, GameId = 2 },
                new Player { Id = 42,Latitude = 55.642780, Longitude = 12.271445, UserID = "eb78fe31-2baf-495c-bf32-6ac91a050d7e", SquadId = 9, IsPatientZero = false, IsZombie = false, BiteCode = 7462, GameId = 2 },
                new Player { Id = 43,Latitude = 55.642780, Longitude = 12.271445, UserID = "56e015d1-9ddf-4b6b-bc56-47b481696b04", SquadId = 6, IsPatientZero = false, IsZombie = true, BiteCode = 8901, GameId = 2 },
                new Player { Id = 44,Latitude = 55.642780, Longitude = 12.271445, UserID = "587e6433-36f0-4ec3-825f-318aecf427fb", SquadId = 10, IsPatientZero = false, IsZombie = false, BiteCode = 9012, GameId = 2 },
                new Player { Id = 45,Latitude = 55.642780, Longitude = 12.271445, UserID = "726f19c4-d67e-4584-aaf9-eb74eb9a6309", SquadId = 6, IsPatientZero = false, IsZombie = true, BiteCode = 1098, GameId = 2 },
                new Player { Id = 46,Latitude = 55.642780, Longitude = 12.271445, UserID = "98ae3b89-2b66-4113-b369-b06e7af7960e", SquadId = 8, IsPatientZero = false, IsZombie = false, BiteCode = 2109, GameId = 2 },
                new Player { Id = 47,Latitude = 55.642780, Longitude = 12.271445, UserID = "c6561be2-a927-4cb4-86ad-42867a09f06d", SquadId = 6, IsPatientZero = false, IsZombie = false, BiteCode = 3210, GameId = 2 },
                new Player { Id = 48,Latitude = 55.642780, Longitude = 12.271445, UserID = "247cb94a-606a-44b2-968f-244f26544797", SquadId = 7, IsPatientZero = false, IsZombie = true, BiteCode = 8049, GameId = 2 },
                new Player { Id = 49,Latitude = 55.642780, Longitude = 12.271445, UserID = "38de1747-35cf-41d0-a275-e6a5e84b0b2e", SquadId = 7, IsPatientZero = false, IsZombie = false, BiteCode = 9127, GameId = 2 },
                new Player { Id = 50,Latitude = 55.642780, Longitude = 12.271445, UserID = "9ce13bc9-7f8b-4be8-97c7-bd8d9370deb0", SquadId = 9, IsPatientZero = false, IsZombie = true, BiteCode = 1379, GameId = 2 },
                new Player { Id = 51,Latitude = 55.642780, Longitude = 12.271445, UserID = "9d394a75-27a0-4a21-b5f3-e0938da2725c", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 2556, GameId = 2 },
                new Player { Id = 52,Latitude = 55.642780, Longitude = 12.271445, UserID = "99000a0c-b069-4f61-9edd-0fc69a8accce", SquadId = null, IsPatientZero = false, IsZombie = true, BiteCode = 1987, GameId = 2 },
                new Player { Id = 53,Latitude = 55.642780, Longitude = 12.271445, UserID = "4afba9be-cd98-4070-9cb2-de3aa91e7203", SquadId = 10, IsPatientZero = false, IsZombie = false, BiteCode = 9876, GameId = 2 },
                new Player { Id = 54,Latitude = 55.642780, Longitude = 12.271445, UserID = "8e942c88-8b46-451c-a594-1029e59ffffe", SquadId = 9, IsPatientZero = false, IsZombie = false, BiteCode = 3837, GameId = 2 },
                new Player { Id = 55,Latitude = 55.642780, Longitude = 12.271445, UserID = "bf84285f-8bea-4639-bff5-404812e17e02", SquadId = 9, IsPatientZero = false, IsZombie = true, BiteCode = 4321, GameId = 2 },
                new Player { Id = 56,Latitude = 55.642780, Longitude = 12.271445, UserID = "6f90589f-df6b-4e3e-8adb-3986b1b1ae20", SquadId = 8, IsPatientZero = false, IsZombie = false, BiteCode = 5698, GameId = 2 },
                new Player { Id = 57,Latitude = 55.642780, Longitude = 12.271445, UserID = "c1dec74f-fc72-4f64-8cd1-4c35c48dba4b", SquadId = null, IsPatientZero = false, IsZombie = true, BiteCode = 6067, GameId = 2 },
                new Player { Id = 58,Latitude = 55.642780, Longitude = 12.271445, UserID = "00a13984-f498-4161-b448-ada0d47b86d4", SquadId = null, IsPatientZero = false, IsZombie = true, BiteCode = 7088, GameId = 2 },
                new Player { Id = 59,Latitude = 55.642780, Longitude = 12.271445, UserID = "4306cf6f-f263-4bcc-a5af-5a4083bf2700", SquadId = 6, IsPatientZero = false, IsZombie = false, BiteCode = 3219, GameId = 2 },
                new Player { Id = 60,Latitude = 55.642780, Longitude = 12.271445, UserID = "4655a760-e6b2-4035-b39c-cf1156f4a0fa", SquadId = 10, IsPatientZero = false, IsZombie = true, BiteCode = 2198, GameId = 2 },
                new Player { Id = 61,Latitude = 55.642780, Longitude = 12.271445, UserID = "8fd9439a-d6f1-42e0-9d7e-04c8e8a0554b", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 8765, GameId = 2 },
                new Player { Id = 62,Latitude = 55.642780, Longitude = 12.271445, UserID = "4fef8bff-b177-4919-a3b1-8d5b81bccedd", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 7654, GameId = 2 },
                new Player { Id = 63,Latitude = 55.642780, Longitude = 12.271445, UserID = "82f60c88-dfcf-4993-96ca-a68188a6a109", SquadId = null, IsPatientZero = false, IsZombie = true, BiteCode = 8594, GameId = 2 },
                new Player { Id = 64,Latitude = 55.642780, Longitude = 12.271445, UserID = "135ac31d-9dd8-4ebf-b1ea-8e530e86dfc3", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 5432, GameId = 2 },
                new Player { Id = 65,Latitude = 55.642780, Longitude = 12.271445, UserID = "fd9ea2b3-f9a3-447b-a614-ef6c44f4b0c6", SquadId = 7, IsPatientZero = false, IsZombie = true, BiteCode = 9645, GameId = 2 },
                new Player { Id = 66,Latitude = 55.642780, Longitude = 12.271445, UserID = "b12a9834-293d-47d3-b6b4-5f8f57c1d092", SquadId = 10, IsPatientZero = false, IsZombie = true, BiteCode = 1034, GameId = 2 },
                new Player { Id = 67,Latitude = 55.642780, Longitude = 12.271445, UserID = "75eaa26a-6552-4822-8973-94948ccafb22", SquadId = 10, IsPatientZero = false, IsZombie = false, BiteCode = 6543, GameId = 2 },
                new Player { Id = 68,Latitude = 55.642780, Longitude = 12.271445, UserID = "1a91b5d0-06df-4eb6-911d-2ce1a9766a9b", SquadId = 8, IsPatientZero = false, IsZombie = true, BiteCode = 2345, GameId = 2 },
                new Player { Id = 69,Latitude = 55.642780, Longitude = 12.271445, UserID = "215a49a4-d9b5-4e86-86ba-35d69781649e", SquadId = 6, IsPatientZero = false, IsZombie = false, BiteCode = 3456, GameId = 2 },
                new Player { Id = 70,Latitude = 55.642780, Longitude = 12.271445, UserID = "5f70e435-d750-4961-a790-704312ae1336", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 2223, GameId = 2 },
                                     
                new Player { Id = 71,Latitude = 55.642780, Longitude = 12.271445, UserID = "d19c226a-22fb-4e6f-81a4-c1d153f929b7", SquadId = null, IsPatientZero = true, IsZombie = true, BiteCode = 2804, GameId = 3 },
                new Player { Id = 72,Latitude = 55.642780, Longitude = 12.271445, UserID = "70a4f7b8-a619-438f-b309-fd333a9e8577", SquadId = 11, IsPatientZero = false, IsZombie = false, BiteCode = 4975, GameId = 3 },
                new Player { Id = 73,Latitude = 55.642780, Longitude = 12.271445, UserID = "1861c804-6669-49bb-b35b-5b2c191b850c", SquadId = 12, IsPatientZero = false, IsZombie = false, BiteCode = 5368, GameId = 3 },
                new Player { Id = 74,Latitude = 55.642780, Longitude = 12.271445, UserID = "245b9d79-0aa1-435d-9878-4896744f221b", SquadId = null, IsPatientZero = false, IsZombie = true, BiteCode = 6729, GameId = 3 },
                new Player { Id = 75,Latitude = 55.642780, Longitude = 12.271445, UserID = "f52236fb-2ab2-4345-bfe5-bfa82b776cf1", SquadId = null, IsPatientZero = false, IsZombie = true, BiteCode = 8901, GameId = 3 },
                new Player { Id = 76,Latitude = 55.642780, Longitude = 12.271445, UserID = "fb55b851-bfeb-4781-8e8a-bc2af03fea63", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 1098, GameId = 3 },
                new Player { Id = 77,Latitude = 55.642780, Longitude = 12.271445, UserID = "203837e7-29b9-400f-bdd8-5094abb4f3ab", SquadId = 13, IsPatientZero = false, IsZombie = true, BiteCode = 3210, GameId = 3 },
                new Player { Id = 78,Latitude = 55.642780, Longitude = 12.271445, UserID = "1ca26c1d-7737-44aa-abc3-4120d1e84cde", SquadId = 14, IsPatientZero = false, IsZombie = true, BiteCode = 9127, GameId = 3 },
                new Player { Id = 79,Latitude = 55.642780, Longitude = 12.271445, UserID = "87e22096-fce7-413d-a9e7-1ae785ef39ac", SquadId = null, IsPatientZero = false, IsZombie = true, BiteCode = 1379, GameId = 3 },
                new Player { Id = 80,Latitude = 55.642780, Longitude = 12.271445, UserID = "61bb9ef9-9f9e-4ce5-b466-4add87940ed8", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 1987, GameId = 3 },
                new Player { Id = 81,Latitude = 55.642780, Longitude = 12.271445, UserID = "db7df012-1f85-44f4-a6b8-6bf95bc9b715", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 3837, GameId = 3 },
                new Player { Id = 82,Latitude = 55.642780, Longitude = 12.271445, UserID = "d676b8d0-8353-4e0e-900c-335719b031eb", SquadId = null, IsPatientZero = false, IsZombie = true, BiteCode = 4321, GameId = 3 },
                new Player { Id = 83,Latitude = 55.642780, Longitude = 12.271445, UserID = "7c303786-36f5-410d-bae1-8fbcb92c6603", SquadId = 11, IsPatientZero = false, IsZombie = false, BiteCode = 5698, GameId = 3 },
                new Player { Id = 84,Latitude = 55.642780, Longitude = 12.271445, UserID = "ba89254d-974f-4d64-abe8-8c2ddeabc1b7", SquadId = 13, IsPatientZero = false, IsZombie = false, BiteCode = 7088, GameId = 3 },
                new Player { Id = 85,Latitude = 55.642780, Longitude = 12.271445, UserID = "43f44f34-5ee1-4b80-95c2-0cf2c2cb0776", SquadId = 13, IsPatientZero = false, IsZombie = true, BiteCode = 2198, GameId = 3 },
                new Player { Id = 86,Latitude = 55.642780, Longitude = 12.271445, UserID = "0920e3c1-f978-4b70-a7f5-9c766595b475", SquadId = null, IsPatientZero = false, IsZombie = true, BiteCode = 7654, GameId = 3 },
                new Player { Id = 87,Latitude = 55.642780, Longitude = 12.271445, UserID = "6251cd7b-0a79-49e6-b4f2-b153bf21ac97", SquadId = 14, IsPatientZero = false, IsZombie = false, BiteCode = 5432, GameId = 3 },
                new Player { Id = 88,Latitude = 55.642780, Longitude = 12.271445, UserID = "a56481e5-9c6a-4aef-9e07-c534a33f0097", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 9645, GameId = 3 },
                new Player { Id = 89,Latitude = 55.642780, Longitude = 12.271445, UserID = "10db85db-9750-415f-b6f3-333bdd678758", SquadId = 12, IsPatientZero = false, IsZombie = false, BiteCode = 6543, GameId = 3 },
                new Player { Id = 90,Latitude = 55.642780, Longitude = 12.271445, UserID = "01731ab5-8f28-4a7b-afe7-c892fc5bd8d9", SquadId = 12, IsPatientZero = false, IsZombie = false, BiteCode = 3456, GameId = 3 },
                new Player { Id = 91,Latitude = 55.642780, Longitude = 12.271445, UserID = "a7551a99-7573-4abc-afae-b7186d35fb5a", SquadId = 12, IsPatientZero = false, IsZombie = false, BiteCode = 2223, GameId = 3 },
                new Player { Id = 92,Latitude = 55.642780, Longitude = 12.271445, UserID = "bbf55298-5e22-49a3-945c-b4d79346a3ed", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 2804, GameId = 3 },
                new Player { Id = 93,Latitude = 55.642780, Longitude = 12.271445, UserID = "02e94a01-3d77-477f-8598-a87a0a91ea1a", SquadId = 13, IsPatientZero = false, IsZombie = true, BiteCode = 4975, GameId = 3 },
                new Player { Id = 94,Latitude = 55.642780, Longitude = 12.271445, UserID = "7596aaf8-c8a6-449a-be88-e2e0263e51de", SquadId = 11, IsPatientZero = false, IsZombie = false, BiteCode = 6729, GameId = 3 },
                new Player { Id = 95,Latitude = 55.642780, Longitude = 12.271445, UserID = "eb78fe31-2baf-495c-bf32-6ac91a050d7e", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 7462, GameId = 3 },
                new Player { Id = 96,Latitude = 55.642780, Longitude = 12.271445, UserID = "587e6433-36f0-4ec3-825f-318aecf427fb", SquadId = null, IsPatientZero = false, IsZombie = true, BiteCode = 9012, GameId = 3 },
                new Player { Id = 97,Latitude = 55.642780, Longitude = 12.271445, UserID = "98ae3b89-2b66-4113-b369-b06e7af7960e", SquadId = 11, IsPatientZero = false, IsZombie = false, BiteCode = 2109, GameId = 3 },
                new Player { Id = 98,Latitude = 55.642780, Longitude = 12.271445, UserID = "c6561be2-a927-4cb4-86ad-42867a09f06d", SquadId = 13, IsPatientZero = false, IsZombie = false, BiteCode = 3210, GameId = 3 },
                new Player { Id = 99, Latitude = 55.642780, Longitude = 12.27144, UserID = "38de1747-35cf-41d0-a275-e6a5e84b0b2e", SquadId = null, IsPatientZero = false, IsZombie = true, BiteCode = 9127, GameId = 3 },
                new Player { Id = 100,Latitude = 55.642780, Longitude = 12.271445, UserID = "9d394a75-27a0-4a21-b5f3-e0938da2725c", SquadId = 13, IsPatientZero = false, IsZombie = false, BiteCode = 2556, GameId = 3 },
                new Player { Id = 101,Latitude = 55.642780, Longitude = 12.271445, UserID = "4afba9be-cd98-4070-9cb2-de3aa91e7203", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 9876, GameId = 3 },
                new Player { Id = 102,Latitude = 55.642780, Longitude = 12.271445, UserID = "8e942c88-8b46-451c-a594-1029e59ffffe", SquadId = 14, IsPatientZero = false, IsZombie = true, BiteCode = 3837, GameId = 3 },
                new Player { Id = 103,Latitude = 55.642780, Longitude = 12.271445, UserID = "6f90589f-df6b-4e3e-8adb-3986b1b1ae20", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 5698, GameId = 3 },
                new Player { Id = 104,Latitude = 55.642780, Longitude = 12.271445, UserID = "4306cf6f-f263-4bcc-a5af-5a4083bf2700", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 3219, GameId = 3 },
                new Player { Id = 105,Latitude = 55.642780, Longitude = 12.271445, UserID = "8fd9439a-d6f1-42e0-9d7e-04c8e8a0554b", SquadId = 11, IsPatientZero = false, IsZombie = true, BiteCode = 8765, GameId = 3 },
                new Player { Id = 106,Latitude = 55.642780, Longitude = 12.271445, UserID = "4fef8bff-b177-4919-a3b1-8d5b81bccedd", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 7654, GameId = 3 },
                new Player { Id = 107,Latitude = 55.642780, Longitude = 12.271445, UserID = "135ac31d-9dd8-4ebf-b1ea-8e530e86dfc3", SquadId = 13, IsPatientZero = false, IsZombie = true, BiteCode = 5432, GameId = 3 },
                new Player { Id = 108,Latitude = 55.642780, Longitude = 12.271445, UserID = "75eaa26a-6552-4822-8973-94948ccafb22", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 6543, GameId = 3 },
                new Player { Id = 109,Latitude = 55.642780, Longitude = 12.271445, UserID = "215a49a4-d9b5-4e86-86ba-35d69781649e", SquadId = 14, IsPatientZero = false, IsZombie = false, BiteCode = 3456, GameId = 3 },
                new Player { Id = 110,Latitude = 55.642780, Longitude = 12.271445, UserID = "5f70e435-d750-4961-a790-704312ae1336", SquadId = 13, IsPatientZero = false, IsZombie = true, BiteCode = 2223, GameId = 3 },
                                      
                new Player { Id = 111,Latitude = 55.642780, Longitude = 12.271445, UserID = "70a4f7b8-a619-438f-b309-fd333a9e8577", SquadId = null, IsPatientZero = true, IsZombie = true, BiteCode = 4975, GameId = 4 },
                new Player { Id = 112,Latitude = 55.642780, Longitude = 12.271445, UserID = "1861c804-6669-49bb-b35b-5b2c191b850c", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 5368, GameId = 4 },
                new Player { Id = 113,Latitude = 55.642780, Longitude = 12.271445, UserID = "fb55b851-bfeb-4781-8e8a-bc2af03fea63", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 1098, GameId = 4 },
                new Player { Id = 114,Latitude = 55.642780, Longitude = 12.271445, UserID = "61bb9ef9-9f9e-4ce5-b466-4add87940ed8", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 1987, GameId = 4 },
                new Player { Id = 115,Latitude = 55.642780, Longitude = 12.271445, UserID = "db7df012-1f85-44f4-a6b8-6bf95bc9b715", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 3837, GameId = 4 },
                new Player { Id = 116,Latitude = 55.642780, Longitude = 12.271445, UserID = "7c303786-36f5-410d-bae1-8fbcb92c6603", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 5698, GameId = 4 },
                new Player { Id = 117,Latitude = 55.642780, Longitude = 12.271445, UserID = "ba89254d-974f-4d64-abe8-8c2ddeabc1b7", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 7088, GameId = 4 },
                new Player { Id = 118,Latitude = 55.642780, Longitude = 12.271445, UserID = "6251cd7b-0a79-49e6-b4f2-b153bf21ac97", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 5432, GameId = 4 },
                new Player { Id = 119,Latitude = 55.642780, Longitude = 12.271445, UserID = "a56481e5-9c6a-4aef-9e07-c534a33f0097", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 9645, GameId = 4 },
                new Player { Id = 120,Latitude = 55.642780, Longitude = 12.271445, UserID = "10db85db-9750-415f-b6f3-333bdd678758", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 6543, GameId = 4 },
                new Player { Id = 121,Latitude = 55.642780, Longitude = 12.271445, UserID = "01731ab5-8f28-4a7b-afe7-c892fc5bd8d9", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 3456, GameId = 4 },
                new Player { Id = 122,Latitude = 55.642780, Longitude = 12.271445, UserID = "a7551a99-7573-4abc-afae-b7186d35fb5a", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 2223, GameId = 4 },
                new Player { Id = 123,Latitude = 55.642780, Longitude = 12.271445, UserID = "bbf55298-5e22-49a3-945c-b4d79346a3ed", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 2804, GameId = 4 },
                new Player { Id = 124,Latitude = 55.642780, Longitude = 12.271445, UserID = "7596aaf8-c8a6-449a-be88-e2e0263e51de", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 6729, GameId = 4 },
                new Player { Id = 125,Latitude = 55.642780, Longitude = 12.271445, UserID = "eb78fe31-2baf-495c-bf32-6ac91a050d7e", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 7462, GameId = 4 },
                new Player { Id = 126,Latitude = 55.642780, Longitude = 12.271445, UserID = "98ae3b89-2b66-4113-b369-b06e7af7960e", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 2109, GameId = 4 },
                new Player { Id = 127,Latitude = 55.642780, Longitude = 12.271445, UserID = "c6561be2-a927-4cb4-86ad-42867a09f06d", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 3210, GameId = 4 },
                new Player { Id = 128,Latitude = 55.642780, Longitude = 12.271445, UserID = "9d394a75-27a0-4a21-b5f3-e0938da2725c", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 2556, GameId = 4 },
                new Player { Id = 129,Latitude = 55.642780, Longitude = 12.271445, UserID = "4afba9be-cd98-4070-9cb2-de3aa91e7203", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 9876, GameId = 4 },
                new Player { Id = 130,Latitude = 55.642780, Longitude = 12.271445, UserID = "6f90589f-df6b-4e3e-8adb-3986b1b1ae20", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 5698, GameId = 4 },
                new Player { Id = 131,Latitude = 55.642780, Longitude = 12.271445, UserID = "4306cf6f-f263-4bcc-a5af-5a4083bf2700", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 3219, GameId = 4 },
                new Player { Id = 132,Latitude = 55.642780, Longitude = 12.271445, UserID = "4fef8bff-b177-4919-a3b1-8d5b81bccedd", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 7654, GameId = 4 },
                new Player { Id = 133,Latitude = 55.642780, Longitude = 12.271445, UserID = "75eaa26a-6552-4822-8973-94948ccafb22", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 6543, GameId = 4 },
                new Player { Id = 134, Latitude = 55.642780, Longitude = 12.27144, UserID = "215a49a4-d9b5-4e86-86ba-35d69781649e", SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 3456, GameId = 4 }
                );
            #endregion

            #region Safezones
            modelBuilder.Entity<Safezone>().HasData(
                new Safezone { Id = 1, Title = "Human HQ", HumanVisible = true, ZombieVisible = true, MapId = 1, Description = "Permanant Safezone for Humans", BeginTime = new DateTime(2023, 03, 11, 09, 00, 00), EndTime = new DateTime(2023, 03, 11, 11, 45, 00), Latitude = 55.642780, Longitude = 12.271445, Radius = 10 },
                new Safezone { Id = 2, Title = "Human HQ", HumanVisible = true, ZombieVisible = true, MapId = 2, Description = "Permanant Safezone for Humans", BeginTime = new DateTime(2023, 03, 12, 09, 00, 00), EndTime = new DateTime(2023, 03, 12, 11, 45, 00), Latitude = 55.642780, Longitude = 12.271445, Radius = 10 },
                new Safezone { Id = 3, Title = "Human HQ", HumanVisible = true, ZombieVisible = true, MapId = 3, Description = "Permanant Safezone for Humans", BeginTime = new DateTime(2023, 03, 29, 09, 00, 00), EndTime = new DateTime(2023, 03, 29, 11, 45, 00), Latitude = 55.642780, Longitude = 12.271445, Radius = 10 },
                new Safezone { Id = 4, Title = "Human HQ", HumanVisible = true, ZombieVisible = true, MapId = 4, Description = "Permanant Safezone for Humans", BeginTime = new DateTime(2023, 03, 31, 09, 00, 00), EndTime = new DateTime(2023, 03, 31, 11, 45, 00), Latitude = 55.642780, Longitude = 12.271445, Radius = 10 }
                );
            #endregion

            #region Squads
            modelBuilder.Entity<Squad>().HasData(
                new Squad { Id = 1,  GameId=1, Name = "Alpha Squad", Description = "A team of elite soldiers trained in special operations and advanced tactics." },
                new Squad { Id = 2,  GameId=1, Name = "Thunder Squad", Description = "A highly skilled unit specializing in airborne operations and lightning fast strikes." },
                new Squad { Id = 3,  GameId=1, Name = "Phoenix Squad", Description = "A group of resilient soldiers known for their ability to rise from the ashes of defeat." },
                new Squad { Id = 4,  GameId=1, Name = "Ghost Squad", Description = "A covert unit specializing in stealth and infiltration missions." },
                new Squad { Id = 5,  GameId=1, Name = "Titan Squad", Description = "A formidable force of heavily armored soldiers with unparalleled firepower." },
                new Squad { Id = 6,  GameId=2, Name = "Chimera Squad", Description = "A team of specialists with unique abilities and powers, able to take on any challenge." },
                new Squad { Id = 7,  GameId=2, Name = "Shadow Squad", Description = "A group of skilled assassins and covert operatives, operating in the shadows." },
                new Squad { Id = 8,  GameId=2, Name = "Valkyrie Squad", Description = "An all-female unit known for their ferocity and bravery in battle." },
                new Squad { Id = 9,  GameId=2, Name = "Fury Squad", Description = "A team of soldiers who fight with a relentless passion and unbridled fury." },
                new Squad { Id = 10, GameId=2, Name = "Storm Squad", Description = "A versatile unit specializing in rapid response and weather-related operations." },
                new Squad { Id = 11, GameId=3, Name = "Sabre Squad", Description = "A highly trained unit specializing in close combat and hand-to-hand combat." },
                new Squad { Id = 12, GameId=3, Name = "Atlas Squad", Description = "A unit of soldiers with incredible strength and endurance, capable of moving mountains." },
                new Squad { Id = 13, GameId=3, Name = "Omega Squad", Description = "A team of soldiers equipped with cutting-edge technology and advanced weaponry." },
                new Squad { Id = 14, GameId=3, Name = "Blade Squad", Description = "A group of highly skilled swordsmen, trained in the art of combat and swordplay." }
                );
            #endregion

            #region Supplies
            modelBuilder.Entity<Supply>().HasData(
                new Supply { Id = 1, Title = "NerfGun Ammo", HumanVisible = true, ZombieVisible = false, MapId = 1, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.AMMO, Amount = 40, Radius = 10 },
                new Supply { Id = 2, Title = "NerfGun", HumanVisible = true, ZombieVisible = false, MapId = 1, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.NERFGUN, Amount = 10, Radius = 10 },
                new Supply { Id = 3, Title = "Grenades", HumanVisible = true, ZombieVisible = false, MapId = 1, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.GENERADE, Amount = 10, Radius = 10 },

                new Supply { Id = 4, Title = "NerfGun Ammo", HumanVisible = true, ZombieVisible = false, MapId = 2, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.AMMO, Amount = 40, Radius = 10 },
                new Supply { Id = 5, Title = "NerfGun", HumanVisible = true, ZombieVisible = false, MapId = 2, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.NERFGUN, Amount = 10, Radius = 10 },
                new Supply { Id = 6, Title = "Grenades", HumanVisible = true, ZombieVisible = false, MapId = 2, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.GENERADE, Amount = 10, Radius = 10 },

                new Supply { Id = 7, Title = "NerfGun Ammo", HumanVisible = true, ZombieVisible = false, MapId = 3, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.AMMO, Amount = 40, Radius = 10 },
                new Supply { Id = 8, Title = "NerfGun", HumanVisible = true, ZombieVisible = false, MapId = 3, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.NERFGUN, Amount = 10, Radius = 10 },
                new Supply { Id = 9, Title = "Grenades", HumanVisible = true, ZombieVisible = false, MapId = 3, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.GENERADE, Amount = 10, Radius = 10 },

                new Supply { Id = 10, Title = "NerfGun Ammo", HumanVisible = true, ZombieVisible = false, MapId = 4, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.AMMO, Amount = 40, Radius = 10 },
                new Supply { Id = 11, Title = "NerfGun", HumanVisible = true, ZombieVisible = false, MapId = 4, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.NERFGUN, Amount = 10, Radius = 10 },
                new Supply { Id = 12, Title = "Grenades", HumanVisible = true, ZombieVisible = false, MapId = 4, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.GENERADE, Amount = 10, Radius = 10 }
                );
            #endregion

        }
    }
}
