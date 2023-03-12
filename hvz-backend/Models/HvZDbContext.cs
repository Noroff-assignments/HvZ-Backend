using hvz_backend.Models.Enums;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace hvz_backend.Models
{
    public class HvZDbContext : DbContext
    {
        // Sets the tables for the database
        
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Kill> Kills { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Safezone> Safezones { get; set; }
        public DbSet<Squad> Squads { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<User> Users { get; set; }
        

        public HvZDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Admins
            modelBuilder.Entity<Admin>().HasData(
                new Admin { Id=1, FirstName= "René", LastName = "Dam Marcker"},
                new Admin { Id=2, FirstName = "Thomas", LastName = "Osterhammel"},
                new Admin { Id=3, FirstName = "Anja", LastName = "Fausing Wilstrup Sundebo"},
                new Admin { Id=4, FirstName = "Michael", LastName = "Neergaard"}
                );
            #endregion

            /*#region Chats
            modelBuilder.Entity<Chat>().HasData(
                new Chat { Id = 1, Message = "Welcome to the game of Humans vs. Zombies! This is the global chat where everyone can communicate with each other.", Mode = ChatMode.GLOBAL, TimeStamp = new DateTime(2023, 1, 21, 12, 00, 00), GameId = 1 },
                new Chat { Id = 2, Message = "Remember to play fair and respect the rules of the game.", Mode = ChatMode.GLOBAL,                                                           TimeStamp = new DateTime(2023, 1, 21, 12, 00, 10), GameId = 1 },
                new Chat { Id = 3, Message = "Humans, stay alert and work together to survive the zombie apocalypse.", Mode = ChatMode.GLOBAL,                                             TimeStamp = new DateTime(2023, 1, 21, 12, 00, 20), GameId = 1 },
                new Chat { Id = 4, Message = "Zombies, work together to infect as many humans as possible and turn them into zombies.", Mode = ChatMode.GLOBAL,                            TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id = 5, Message = "Hey, everyone! Good luck to both the human and zombie factions!", Mode = ChatMode.GLOBAL,                                                    TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id = 6, Message = "Thanks, Rainbow! May the best team win!", Mode = ChatMode.GLOBAL,                                                                            TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id = 7, Message = "Hey humans, this is the chat for our faction. Let's work together to survive and outsmart the zombies.", Mode = ChatMode.HUMAN,              TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id = 8, Message = "Welcome zombies, this is our chat. Let's work together to infect as many humans as we can.", Mode = ChatMode.ZOMBIE,                         TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id = 9, Message = "Remember to stock up on supplies and weapons, and be aware of your surroundings.", Mode = ChatMode.HUMAN,                                    TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =10, Message = "Let's show the humans what a real zombie apocalypse looks like!", Mode = ChatMode.ZOMBIE,                                                    TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =11, Message = "If you see a zombie, try to avoid them or take them down with your weapons.", Mode = ChatMode.HUMAN,                                         TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =12, Message = "I'm ready to survive this apocalypse!", Mode = ChatMode.GLOBAL,                                                                              TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =13, Message = "Remember to coordinate and strategize. Don't just mindlessly chase after humans.", Mode = ChatMode.ZOMBIE,                                   TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =14, Message = "If you see a lone human, don't be afraid to call for backup from your fellow zombies.", Mode = ChatMode.ZOMBIE,                              TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =15, Message = "I'm ready to eat some brains!", Mode = ChatMode.GLOBAL,                                                                                      TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =16, Message = "Hey squad, this is our chat where we can communicate with each other more easily.", Mode = ChatMode.SQUAD,                                   TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =17, Message = "Let's coordinate our movements and stick together for safety.", Mode = ChatMode.SQUAD,                                                       TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =18, Message = "Humans, if you see a zombie, call for backup from your squadmates.", Mode = ChatMode.SQUAD,                                                  TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =19, Message = "Zombies, if you spot a group of humans, let your squadmates know so you can coordinate an attack.", Mode = ChatMode.SQUAD,                   TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =20, Message = "Remember to have each other's backs and work together to win the game!", Mode = ChatMode.SQUAD,                                              TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =21, Message = "Hey, humans! Let's stick together and watch each other's backs.", Mode = ChatMode.HUMAN,                                                     TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =22, Message = "Absolutely. We need to be careful and avoid any unnecessary risks.", Mode = ChatMode.HUMAN,                                                  TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =23, Message = "Remember, let's keep this game fun and respectful for everyone.", Mode = ChatMode.GLOBAL,                                                    TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =24, Message = "Squad, we need to move quickly and avoid drawing attention to ourselves.", Mode = ChatMode.SQUAD,                                            TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =25, Message = "Agreed. We don't want to get surrounded by zombies.", Mode = ChatMode.SQUAD,                                                                 TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =26, Message = "Zombies, listen up! We need to coordinate our attacks and take down the humans one by one.", Mode = ChatMode.ZOMBIE,                         TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =27, Message = "I agree. We can't let them overpower us.", Mode = ChatMode.ZOMBIE,                                                                           TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =28, Message = "I found a shortcut through the parking lot that can lead us to the next safe zone.", Mode = ChatMode.SQUAD,                                  TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =29, Message = "Nice one, Player3! Let's go that way and stay alert.", Mode = ChatMode.SQUAD,                                                                TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =30, Message = "Zombies incoming! Let's take them down together!", Mode = ChatMode.SQUAD,                                                                    TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =31, Message = "Does anyone know where we can find some more supplies?", Mode = ChatMode.HUMAN,                                                              TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =32, Message = "I just saw a group of humans near the Science Building. Let's go get them!", Mode = ChatMode.ZOMBIE,                                         TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 },
                new Chat { Id =33, Message = "Wait, hold on. We should wait for backup and attack them when they least expect it.", Mode = ChatMode.ZOMBIE,                                TimeStamp = new DateTime(2023, 1, 21, 12, 00, 30), GameId = 1 }
                );
            #endregion*/

            #region Games
            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    Id = 1,
                    AdminId = 2,
                    BeginTime = new DateTime(2023, 03, 11, 09, 00, 00),
                    EndTime = new DateTime(2023, 03, 11, 12, 00, 00),
                    Status = StateGame.Completed,
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
                    AdminId = 2,
                    BeginTime = new DateTime(2023, 03, 12, 09, 00, 00),
                    EndTime = new DateTime(2023, 03, 12, 12, 00, 00),
                    Status = StateGame.Completed,
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
                    AdminId = 4,
                    BeginTime = new DateTime(2023, 03, 29, 09, 00, 00),
                    EndTime = new DateTime(2023, 03, 29, 12, 00, 00),
                    Status = StateGame.Running,
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
                    AdminId = 1,
                    BeginTime = new DateTime(2023, 03, 31, 09, 00, 00),
                    EndTime = new DateTime(2023, 03, 31, 12, 00, 00),
                    Status = StateGame.Registrating,
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
                ) ;
            #endregion
 
            #region Kills
            modelBuilder.Entity<Kill>().HasData(
                new Kill { Id = 1, GameId = 1, KillerId = 1,  VictimId = 18, TimeDead = new DateTime(2023, 03, 11, 09, 10, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 2, GameId = 1, KillerId = 1,  VictimId = 24, TimeDead = new DateTime(2023, 03, 11, 09, 23, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 3, GameId = 1, KillerId = 18, VictimId = 3,  TimeDead = new DateTime(2023, 03, 11, 09, 43, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 4, GameId = 1, KillerId = 24, VictimId = 9,  TimeDead = new DateTime(2023, 03, 11, 09, 55, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 5, GameId = 1, KillerId = 1,  VictimId = 7,  TimeDead = new DateTime(2023, 03, 11, 10, 10, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 6, GameId = 1, KillerId = 3,  VictimId = 33, TimeDead = new DateTime(2023, 03, 11, 10, 16, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 7, GameId = 1, KillerId = 3,  VictimId = 13, TimeDead = new DateTime(2023, 03, 11, 10, 33, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 8, GameId = 1, KillerId = 7,  VictimId = 11, TimeDead = new DateTime(2023, 03, 11, 10, 47, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 9, GameId = 1, KillerId = 9,  VictimId = 16, TimeDead = new DateTime(2023, 03, 11, 10, 56, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id =10, GameId = 1, KillerId = 1,  VictimId = 22, TimeDead = new DateTime(2023, 03, 11, 11, 17, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id =11, GameId = 1, KillerId = 18, VictimId = 24, TimeDead = new DateTime(2023, 03, 11, 11, 22, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id =12, GameId = 1, KillerId = 16, VictimId = 31, TimeDead = new DateTime(2023, 03, 11, 11, 38, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id =13, GameId = 1, KillerId = 11, VictimId = 26, TimeDead = new DateTime(2023, 03, 11, 11, 49, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id =14, GameId = 1, KillerId = 13, VictimId = 28, TimeDead = new DateTime(2023, 03, 11, 11, 51, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },

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

                new Kill { Id = 30, GameId = 3, KillerId = 2,  VictimId = 12, TimeDead = new DateTime(2023, 03, 29, 09, 13, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 30, GameId = 3, KillerId = 2,  VictimId = 15, TimeDead = new DateTime(2023, 03, 29, 09, 24, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 30, GameId = 3, KillerId = 12, VictimId = 20, TimeDead = new DateTime(2023, 03, 29, 09, 39, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 30, GameId = 3, KillerId = 2,  VictimId = 25, TimeDead = new DateTime(2023, 03, 29, 09, 55, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 30, GameId = 3, KillerId = 15, VictimId = 8,  TimeDead = new DateTime(2023, 03, 29, 10, 07, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 30, GameId = 3, KillerId = 20, VictimId = 44, TimeDead = new DateTime(2023, 03, 29, 10, 15, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 30, GameId = 3, KillerId = 25, VictimId = 70, TimeDead = new DateTime(2023, 03, 29, 10, 20, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 30, GameId = 3, KillerId = 2,  VictimId = 64, TimeDead = new DateTime(2023, 03, 29, 10, 35, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 30, GameId = 3, KillerId = 8,  VictimId = 49, TimeDead = new DateTime(2023, 03, 29, 10, 40, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 30, GameId = 3, KillerId = 15, VictimId = 6,  TimeDead = new DateTime(2023, 03, 29, 10, 47, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 30, GameId = 3, KillerId = 44, VictimId = 39, TimeDead = new DateTime(2023, 03, 29, 11, 02, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 30, GameId = 3, KillerId = 70, VictimId = 27, TimeDead = new DateTime(2023, 03, 29, 11, 16, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 30, GameId = 3, KillerId = 64, VictimId = 14, TimeDead = new DateTime(2023, 03, 29, 11, 24, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 30, GameId = 3, KillerId = 6,  VictimId = 61, TimeDead = new DateTime(2023, 03, 29, 11, 41, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." },
                new Kill { Id = 30, GameId = 3, KillerId = 27, VictimId = 54, TimeDead = new DateTime(2023, 03, 29, 11, 49, 00), DeadStory = "A lone human is hunted down and brutally killed by a ravenous zombie." }

                );
            #endregion

            #region Maps
            modelBuilder.Entity<Map>().HasData(
                new Map { Id = 1, GameId = 1, Latitude = 55.642780, Longitude = 12.271445, MapName = "Experis Academy Denmark", MapDescription = "The location for the Experis Academy World Championship 2023."},
                new Map { Id = 2, GameId = 2, Latitude = 55.642780, Longitude = 12.271445, MapName = "Experis Academy Denmark", MapDescription = "The location for the Experis Academy World Championship 2023." },
                new Map { Id = 3, GameId = 3, Latitude = 55.642780, Longitude = 12.271445, MapName = "Experis Academy Denmark", MapDescription = "The location for the Experis Academy World Championship 2023." },
                new Map { Id = 4, GameId = 4, Latitude = 55.642780, Longitude = 12.271445, MapName = "Experis Academy Denmark", MapDescription = "The location for the Experis Academy World Championship 2023." }
                );
            #endregion

            #region Missions
            modelBuilder.Entity<Mission>().HasData(
                new Mission { Id = 1, Title = "Get Supplies.",     HumanVisible = true, ZombieVisible = false, MapId = 1, Description = "Prepare for the upcoming Zombie attack.",                           BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559 },
                new Mission { Id = 2, Title = "Get fuel.",         HumanVisible = true, ZombieVisible = false, MapId = 1, Description = "Reach the point.",                                                  BeginTime = new DateTime(2023, 03, 11, 10, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 40, 00), Latitude = 55.643022, Longitude = 12.272587 },
                new Mission { Id = 3, Title = "Get Radio.",        HumanVisible = true, ZombieVisible = false, MapId = 1, Description = "Reach the point and hold it.",                                      BeginTime = new DateTime(2023, 03, 11, 11, 00, 00), EndTime = new DateTime(2023, 03, 11, 11, 05, 00), Latitude = 55.642328, Longitude = 12.272512 },
                new Mission { Id = 4, Title = "Stand Your Ground", HumanVisible = true, ZombieVisible = true,  MapId = 1, Description = "Zombies shall capture the flag and the humans need to defend it.",  BeginTime = new DateTime(2023, 03, 11, 11, 45, 00), EndTime = new DateTime(2023, 03, 11, 12, 00, 00), Latitude = 55.642780, Longitude = 12.271445 },

                new Mission { Id = 5, Title = "Get Supplies.",     HumanVisible = true, ZombieVisible = false, MapId = 2, Description = "Prepare for the upcoming Zombie attack.",                           BeginTime = new DateTime(2023, 03, 12, 09, 30, 00), EndTime = new DateTime(2023, 03, 12, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559 },
                new Mission { Id = 6, Title = "Get fuel.",         HumanVisible = true, ZombieVisible = false, MapId = 2, Description = "Reach the point.",                                                  BeginTime = new DateTime(2023, 03, 12, 10, 30, 00), EndTime = new DateTime(2023, 03, 12, 10, 40, 00), Latitude = 55.643022, Longitude = 12.272587 },
                new Mission { Id = 7, Title = "Get Radio.",        HumanVisible = true, ZombieVisible = false, MapId = 2, Description = "Reach the point and hold it.",                                      BeginTime = new DateTime(2023, 03, 12, 11, 00, 00), EndTime = new DateTime(2023, 03, 12, 11, 05, 00), Latitude = 55.642328, Longitude = 12.272512 },
                new Mission { Id = 8, Title = "Stand Your Ground", HumanVisible = true, ZombieVisible = true,  MapId = 2, Description = "Zombies shall capture the flag and the humans need to defend it.",  BeginTime = new DateTime(2023, 03, 12, 11, 45, 00), EndTime = new DateTime(2023, 03, 12, 12, 00, 00), Latitude = 55.642780, Longitude = 12.271445 },

                new Mission { Id = 9, Title = "Get Supplies.",      HumanVisible = true, ZombieVisible = false, MapId = 3, Description = "Prepare for the upcoming Zombie attack.",                          BeginTime = new DateTime(2023, 03, 29, 09, 30, 00), EndTime = new DateTime(2023, 03, 29, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559 },
                new Mission { Id = 10, Title = "Get fuel.",         HumanVisible = true, ZombieVisible = false, MapId = 3, Description = "Reach the point.",                                                 BeginTime = new DateTime(2023, 03, 29, 10, 30, 00), EndTime = new DateTime(2023, 03, 29, 10, 40, 00), Latitude = 55.643022, Longitude = 12.272587 },
                new Mission { Id = 11, Title = "Get Radio.",        HumanVisible = true, ZombieVisible = false, MapId = 3, Description = "Reach the point and hold it.",                                     BeginTime = new DateTime(2023, 03, 29, 11, 00, 00), EndTime = new DateTime(2023, 03, 29, 11, 05, 00), Latitude = 55.642328, Longitude = 12.272512 },
                new Mission { Id = 12, Title = "Stand Your Ground", HumanVisible = true, ZombieVisible = true,  MapId = 3, Description = "Zombies shall capture the flag and the humans need to defend it.", BeginTime = new DateTime(2023, 03, 29, 11, 45, 00), EndTime = new DateTime(2023, 03, 29, 12, 00, 00), Latitude = 55.642780, Longitude = 12.271445 },

                new Mission { Id = 13, Title = "Get Supplies.",     HumanVisible = true, ZombieVisible = false, MapId = 4, Description = "Prepare for the upcoming Zombie attack.",                          BeginTime = new DateTime(2023, 03, 31, 09, 30, 00), EndTime = new DateTime(2023, 03, 31, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559 },
                new Mission { Id = 14, Title = "Get fuel.",         HumanVisible = true, ZombieVisible = false, MapId = 4, Description = "Reach the point.",                                                 BeginTime = new DateTime(2023, 03, 31, 10, 30, 00), EndTime = new DateTime(2023, 03, 31, 10, 40, 00), Latitude = 55.643022, Longitude = 12.272587 },
                new Mission { Id = 15, Title = "Get Radio.",        HumanVisible = true, ZombieVisible = false, MapId = 4, Description = "Reach the point and hold it.",                                     BeginTime = new DateTime(2023, 03, 31, 11, 00, 00), EndTime = new DateTime(2023, 03, 31, 11, 05, 00), Latitude = 55.642328, Longitude = 12.272512 },
                new Mission { Id = 16, Title = "Stand Your Ground", HumanVisible = true, ZombieVisible = true,  MapId = 4, Description = "Zombies shall capture the flag and the humans need to defend it.", BeginTime = new DateTime(2023, 03, 31, 11, 45, 00), EndTime = new DateTime(2023, 03, 31, 12, 00, 00), Latitude = 55.642780, Longitude = 12.271445 }
                );
            #endregion

            
            #region Players
            modelBuilder.Entity<Player>().HasData(
                new Player { Id = 1,  UserId = 1,  SquadId = null,  IsPatientZero = true,  IsZombie = true,  BiteCode = 1543, GameId = 1 },
                new Player { Id = 2,  UserId = 2,  SquadId = 2,     IsPatientZero = false, IsZombie = false, BiteCode = 2804, GameId = 1 },
                new Player { Id = 3,  UserId = 3,  SquadId = 2,     IsPatientZero = false, IsZombie = true,  BiteCode = 3110, GameId = 1 },
                new Player { Id = 4,  UserId = 4,  SquadId = 3,     IsPatientZero = false, IsZombie = false, BiteCode = 4975, GameId = 1 },
                new Player { Id = 5,  UserId = 5,  SquadId = 3,     IsPatientZero = false, IsZombie = false, BiteCode = 5368, GameId = 1 },
                new Player { Id = 6,  UserId = 6,  SquadId = null,  IsPatientZero = false, IsZombie = false, BiteCode = 6729, GameId = 1 },
                new Player { Id = 7,  UserId = 7,  SquadId = 4,     IsPatientZero = false, IsZombie = true,  BiteCode = 7462, GameId = 1 },
                new Player { Id = 8,  UserId = 8,  SquadId = 2,     IsPatientZero = false, IsZombie = false, BiteCode = 8901, GameId = 1 },
                new Player { Id = 9,  UserId = 9,  SquadId = 1,     IsPatientZero = false, IsZombie = true,  BiteCode = 9012, GameId = 1 },
                new Player { Id = 10, UserId = 10, SquadId = null,  IsPatientZero = false, IsZombie = false, BiteCode = 1098, GameId = 1 },
                new Player { Id = 11, UserId = 11, SquadId = null,  IsPatientZero = false, IsZombie = true,  BiteCode = 2109, GameId = 1 },
                new Player { Id = 12, UserId = 12, SquadId = 2,     IsPatientZero = false, IsZombie = false, BiteCode = 3210, GameId = 1 },
                new Player { Id = 13, UserId = 13, SquadId = 4,     IsPatientZero = false, IsZombie = true,  BiteCode = 8049, GameId = 1 },
                new Player { Id = 14, UserId = 14, SquadId = null,  IsPatientZero = false, IsZombie = false, BiteCode = 9127, GameId = 1 },
                new Player { Id = 15, UserId = 15, SquadId = 5,     IsPatientZero = false, IsZombie = false, BiteCode = 1379, GameId = 1 },
                new Player { Id = 16, UserId = 16, SquadId = 3,     IsPatientZero = false, IsZombie = true,  BiteCode = 2556, GameId = 1 },
                new Player { Id = 17, UserId = 17, SquadId = null,  IsPatientZero = false, IsZombie = false, BiteCode = 1987, GameId = 1 },
                new Player { Id = 18, UserId = 18, SquadId = 1,     IsPatientZero = false, IsZombie = true,  BiteCode = 9876, GameId = 1 },
                new Player { Id = 19, UserId = 19, SquadId = 5,     IsPatientZero = false, IsZombie = false, BiteCode = 3837, GameId = 1 },
                new Player { Id = 20, UserId = 20, SquadId = null,  IsPatientZero = false, IsZombie = false, BiteCode = 4321, GameId = 1 },
                new Player { Id = 21, UserId = 21, SquadId = 3,     IsPatientZero = false, IsZombie = false, BiteCode = 5698, GameId = 1 },
                new Player { Id = 22, UserId = 22, SquadId = 5,     IsPatientZero = false, IsZombie = true,  BiteCode = 6067, GameId = 1 },
                new Player { Id = 23, UserId = 23, SquadId = 4,     IsPatientZero = false, IsZombie = false, BiteCode = 7088, GameId = 1 },
                new Player { Id = 24, UserId = 24, SquadId = null,  IsPatientZero = false, IsZombie = true,  BiteCode = 3219, GameId = 1 },
                new Player { Id = 25, UserId = 25, SquadId = 4,     IsPatientZero = false, IsZombie = false, BiteCode = 2198, GameId = 1 },
                new Player { Id = 26, UserId = 26, SquadId = null,  IsPatientZero = false, IsZombie = true,  BiteCode = 8765, GameId = 1 },
                new Player { Id = 27, UserId = 27, SquadId = 1,     IsPatientZero = false, IsZombie = false, BiteCode = 7654, GameId = 1 },
                new Player { Id = 28, UserId = 28, SquadId = 4,     IsPatientZero = false, IsZombie = true,  BiteCode = 8594, GameId = 1 },
                new Player { Id = 29, UserId = 29, SquadId = null,  IsPatientZero = false, IsZombie = false, BiteCode = 5432, GameId = 1 },
                new Player { Id = 30, UserId = 30, SquadId = 3,     IsPatientZero = false, IsZombie = false, BiteCode = 9645, GameId = 1 },
                new Player { Id = 31, UserId = 31, SquadId = 5,     IsPatientZero = false, IsZombie = true,  BiteCode = 1034, GameId = 1 },
                new Player { Id = 32, UserId = 32, SquadId = 2,     IsPatientZero = false, IsZombie = false, BiteCode = 6543, GameId = 1 },
                new Player { Id = 33, UserId = 33, SquadId = null,  IsPatientZero = false, IsZombie = true,  BiteCode = 2345, GameId = 1 },
                new Player { Id = 34, UserId = 34, SquadId = 2,     IsPatientZero = false, IsZombie = false, BiteCode = 3456, GameId = 1 },
                new Player { Id = 35, UserId = 35, SquadId = 3,     IsPatientZero = false, IsZombie = false, BiteCode = 2223, GameId = 1 },

                new Player { Id = 36, UserId = 36, SquadId = null, IsPatientZero = true,  IsZombie = true,  BiteCode = 1543, GameId = 2 },
                new Player { Id = 37, UserId = 37, SquadId = 7,    IsPatientZero = false, IsZombie = false, BiteCode = 2804, GameId = 2 },
                new Player { Id = 38, UserId = 38, SquadId = 9,    IsPatientZero = false, IsZombie = true,  BiteCode = 3110, GameId = 2 },
                new Player { Id = 39, UserId = 39, SquadId = 10,   IsPatientZero = false, IsZombie = false, BiteCode = 4975, GameId = 2 },
                new Player { Id = 40, UserId = 40, SquadId = 8,    IsPatientZero = false, IsZombie = true,  BiteCode = 5368, GameId = 2 },
                new Player { Id = 41, UserId = 41, SquadId = 9,    IsPatientZero = false, IsZombie = false, BiteCode = 6729, GameId = 2 },
                new Player { Id = 42, UserId = 42, SquadId = 9,    IsPatientZero = false, IsZombie = false, BiteCode = 7462, GameId = 2 },
                new Player { Id = 43, UserId = 43, SquadId = 6,    IsPatientZero = false, IsZombie = true,  BiteCode = 8901, GameId = 2 },
                new Player { Id = 44, UserId = 44, SquadId = 10,   IsPatientZero = false, IsZombie = false, BiteCode = 9012, GameId = 2 },
                new Player { Id = 45, UserId = 45, SquadId = 6,    IsPatientZero = false, IsZombie = true,  BiteCode = 1098, GameId = 2 },
                new Player { Id = 46, UserId = 46, SquadId = 8,    IsPatientZero = false, IsZombie = false, BiteCode = 2109, GameId = 2 },
                new Player { Id = 47, UserId = 47, SquadId = 6,    IsPatientZero = false, IsZombie = false, BiteCode = 3210, GameId = 2 },
                new Player { Id = 48, UserId = 48, SquadId = 7,    IsPatientZero = false, IsZombie = true,  BiteCode = 8049, GameId = 2 },
                new Player { Id = 49, UserId = 49, SquadId = 7,    IsPatientZero = false, IsZombie = false, BiteCode = 9127, GameId = 2 },
                new Player { Id = 50, UserId = 50, SquadId = 9,    IsPatientZero = false, IsZombie = true,  BiteCode = 1379, GameId = 2 },
                new Player { Id = 51, UserId = 51, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 2556, GameId = 2 },
                new Player { Id = 52, UserId = 52, SquadId = null, IsPatientZero = false, IsZombie = true,  BiteCode = 1987, GameId = 2 },
                new Player { Id = 53, UserId = 53, SquadId = 10,   IsPatientZero = false, IsZombie = false, BiteCode = 9876, GameId = 2 },
                new Player { Id = 54, UserId = 54, SquadId = 9,    IsPatientZero = false, IsZombie = false, BiteCode = 3837, GameId = 2 },
                new Player { Id = 55, UserId = 55, SquadId = 9,    IsPatientZero = false, IsZombie = true,  BiteCode = 4321, GameId = 2 },
                new Player { Id = 56, UserId = 56, SquadId = 8,    IsPatientZero = false, IsZombie = false, BiteCode = 5698, GameId = 2 },
                new Player { Id = 57, UserId = 57, SquadId = null, IsPatientZero = false, IsZombie = true,  BiteCode = 6067, GameId = 2 },
                new Player { Id = 58, UserId = 58, SquadId = null, IsPatientZero = false, IsZombie = true,  BiteCode = 7088, GameId = 2 },
                new Player { Id = 59, UserId = 59, SquadId = 6,    IsPatientZero = false, IsZombie = false, BiteCode = 3219, GameId = 2 },
                new Player { Id = 60, UserId = 60, SquadId = 10,   IsPatientZero = false, IsZombie = true,  BiteCode = 2198, GameId = 2 },
                new Player { Id = 61, UserId = 61, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 8765, GameId = 2 },
                new Player { Id = 62, UserId = 62, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 7654, GameId = 2 },
                new Player { Id = 63, UserId = 63, SquadId = null, IsPatientZero = false, IsZombie = true,  BiteCode = 8594, GameId = 2 },
                new Player { Id = 64, UserId = 64, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 5432, GameId = 2 },
                new Player { Id = 65, UserId = 65, SquadId = 7,    IsPatientZero = false, IsZombie = true,  BiteCode = 9645, GameId = 2 },
                new Player { Id = 66, UserId = 66, SquadId = 10,   IsPatientZero = false, IsZombie = true,  BiteCode = 1034, GameId = 2 },
                new Player { Id = 67, UserId = 67, SquadId = 10,   IsPatientZero = false, IsZombie = false, BiteCode = 6543, GameId = 2 },
                new Player { Id = 68, UserId = 68, SquadId = 8,    IsPatientZero = false, IsZombie = true,  BiteCode = 2345, GameId = 2 },
                new Player { Id = 69, UserId = 69, SquadId = 6,    IsPatientZero = false, IsZombie = false, BiteCode = 3456, GameId = 2 },
                new Player { Id = 70, UserId = 70, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 2223, GameId = 2 },

                new Player { Id = 71, UserId = 2,  SquadId = null, IsPatientZero = true,  IsZombie = true,  BiteCode = 2804, GameId = 3 },
                new Player { Id = 72, UserId = 4,  SquadId = 11,   IsPatientZero = false, IsZombie = false, BiteCode = 4975, GameId = 3 },
                new Player { Id = 73, UserId = 5,  SquadId = 12,   IsPatientZero = false, IsZombie = false, BiteCode = 5368, GameId = 3 },
                new Player { Id = 74, UserId = 6,  SquadId = null, IsPatientZero = false, IsZombie = true,  BiteCode = 6729, GameId = 3 },
                new Player { Id = 75, UserId = 8,  SquadId = null, IsPatientZero = false, IsZombie = true,  BiteCode = 8901, GameId = 3 },
                new Player { Id = 76, UserId = 10, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 1098, GameId = 3 },
                new Player { Id = 77, UserId = 12, SquadId = 13,   IsPatientZero = false, IsZombie = true,  BiteCode = 3210, GameId = 3 },
                new Player { Id = 78, UserId = 14, SquadId = 14,   IsPatientZero = false, IsZombie = true,  BiteCode = 9127, GameId = 3 },
                new Player { Id = 79, UserId = 15, SquadId = null, IsPatientZero = false, IsZombie = true,  BiteCode = 1379, GameId = 3 },
                new Player { Id = 80, UserId = 17, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 1987, GameId = 3 },
                new Player { Id = 81, UserId = 19, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 3837, GameId = 3 },
                new Player { Id = 82, UserId = 20, SquadId = null, IsPatientZero = false, IsZombie = true,  BiteCode = 4321, GameId = 3 },
                new Player { Id = 83, UserId = 21, SquadId = 11,   IsPatientZero = false, IsZombie = false, BiteCode = 5698, GameId = 3 },
                new Player { Id = 84, UserId = 23, SquadId = 13,   IsPatientZero = false, IsZombie = false, BiteCode = 7088, GameId = 3 },
                new Player { Id = 85, UserId = 25, SquadId = 13,   IsPatientZero = false, IsZombie = true,  BiteCode = 2198, GameId = 3 },
                new Player { Id = 86, UserId = 27, SquadId = null, IsPatientZero = false, IsZombie = true,  BiteCode = 7654, GameId = 3 },
                new Player { Id = 87, UserId = 29, SquadId = 14,   IsPatientZero = false, IsZombie = false, BiteCode = 5432, GameId = 3 },
                new Player { Id = 88, UserId = 30, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 9645, GameId = 3 },
                new Player { Id = 89, UserId = 32, SquadId = 12,   IsPatientZero = false, IsZombie = false, BiteCode = 6543, GameId = 3 },
                new Player { Id = 90, UserId = 34, SquadId = 12,   IsPatientZero = false, IsZombie = false, BiteCode = 3456, GameId = 3 },
                new Player { Id = 91, UserId = 35, SquadId = 12,   IsPatientZero = false, IsZombie = false, BiteCode = 2223, GameId = 3 },
                new Player { Id = 92, UserId = 37, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 2804, GameId = 3 },
                new Player { Id = 93, UserId = 39, SquadId = 13,   IsPatientZero = false, IsZombie = true,  BiteCode = 4975, GameId = 3 },
                new Player { Id = 94, UserId = 41, SquadId = 11,   IsPatientZero = false, IsZombie = false, BiteCode = 6729, GameId = 3 },
                new Player { Id = 95, UserId = 42, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 7462, GameId = 3 },
                new Player { Id = 96, UserId = 44, SquadId = null, IsPatientZero = false, IsZombie = true,  BiteCode = 9012, GameId = 3 },
                new Player { Id = 97, UserId = 46, SquadId = 11,   IsPatientZero = false, IsZombie = false, BiteCode = 2109, GameId = 3 },
                new Player { Id = 98, UserId = 47, SquadId = 13,   IsPatientZero = false, IsZombie = false, BiteCode = 3210, GameId = 3 },
                new Player { Id = 99, UserId = 49, SquadId = null, IsPatientZero = false, IsZombie = true,  BiteCode = 9127, GameId = 3 },
                new Player { Id = 100,UserId = 51, SquadId = 13,   IsPatientZero = false, IsZombie = false, BiteCode = 2556, GameId = 3 },
                new Player { Id = 101,UserId = 53, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 9876, GameId = 3 },
                new Player { Id = 102,UserId = 54, SquadId = 14,   IsPatientZero = false, IsZombie = true,  BiteCode = 3837, GameId = 3 },
                new Player { Id = 103,UserId = 56, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 5698, GameId = 3 },
                new Player { Id = 104,UserId = 59, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 3219, GameId = 3 },
                new Player { Id = 105,UserId = 61, SquadId = 11,   IsPatientZero = false, IsZombie = true,  BiteCode = 8765, GameId = 3 },
                new Player { Id = 106,UserId = 62, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 7654, GameId = 3 },
                new Player { Id = 107,UserId = 64, SquadId = 13,   IsPatientZero = false, IsZombie = true,  BiteCode = 5432, GameId = 3 },
                new Player { Id = 108,UserId = 67, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 6543, GameId = 3 },
                new Player { Id = 109,UserId = 69, SquadId = 14,   IsPatientZero = false, IsZombie = false, BiteCode = 3456, GameId = 3 },
                new Player { Id = 110,UserId = 70, SquadId = 13,   IsPatientZero = false, IsZombie = true,  BiteCode = 2223, GameId = 3 },

                new Player { Id = 111,UserId = 4,  SquadId = null, IsPatientZero = true,  IsZombie = true,  BiteCode = 4975, GameId = 4 },
                new Player { Id = 112,UserId = 5,  SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 5368, GameId = 4 },
                new Player { Id = 113,UserId = 10, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 1098, GameId = 4 },
                new Player { Id = 114,UserId = 17, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 1987, GameId = 4 },
                new Player { Id = 115,UserId = 19, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 3837, GameId = 4 },
                new Player { Id = 116,UserId = 21, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 5698, GameId = 4 },
                new Player { Id = 117,UserId = 23, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 7088, GameId = 4 },
                new Player { Id = 118,UserId = 29, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 5432, GameId = 4 },
                new Player { Id = 119,UserId = 30, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 9645, GameId = 4 },
                new Player { Id = 120,UserId = 32, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 6543, GameId = 4 },
                new Player { Id = 121,UserId = 34, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 3456, GameId = 4 },
                new Player { Id = 122,UserId = 35, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 2223, GameId = 4 },
                new Player { Id = 123,UserId = 37, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 2804, GameId = 4 },
                new Player { Id = 124,UserId = 41, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 6729, GameId = 4 },
                new Player { Id = 125,UserId = 42, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 7462, GameId = 4 },
                new Player { Id = 126,UserId = 46, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 2109, GameId = 4 },
                new Player { Id = 127,UserId = 47, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 3210, GameId = 4 },
                new Player { Id = 128,UserId = 51, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 2556, GameId = 4 },
                new Player { Id = 129,UserId = 53, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 9876, GameId = 4 },
                new Player { Id = 130,UserId = 56, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 5698, GameId = 4 },
                new Player { Id = 131,UserId = 59, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 3219, GameId = 4 },
                new Player { Id = 132,UserId = 62, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 7654, GameId = 4 },
                new Player { Id = 133,UserId = 67, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 6543, GameId = 4 },
                new Player { Id = 134,UserId = 69, SquadId = null, IsPatientZero = false, IsZombie = false, BiteCode = 3456, GameId = 4 }
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
                new Squad { Id = 1,  Name = "Alpha Squad",      Description = "A team of elite soldiers trained in special operations and advanced tactics." },
                new Squad { Id = 2,  Name = "Thunder Squad",    Description = "A highly skilled unit specializing in airborne operations and lightning fast strikes." },
                new Squad { Id = 3,  Name = "Phoenix Squad",    Description = "A group of resilient soldiers known for their ability to rise from the ashes of defeat." },
                new Squad { Id = 4,  Name = "Ghost Squad",      Description = "A covert unit specializing in stealth and infiltration missions." },
                new Squad { Id = 5,  Name = "Titan Squad",      Description = "A formidable force of heavily armored soldiers with unparalleled firepower." },
                new Squad { Id = 6,  Name = "Chimera Squad",    Description = "A team of specialists with unique abilities and powers, able to take on any challenge." },
                new Squad { Id = 7,  Name = "Shadow Squad",     Description = "A group of skilled assassins and covert operatives, operating in the shadows." },
                new Squad { Id = 8,  Name = "Valkyrie Squad",   Description = "An all-female unit known for their ferocity and bravery in battle." },
                new Squad { Id = 9,  Name = "Fury Squad",       Description = "A team of soldiers who fight with a relentless passion and unbridled fury." },
                new Squad { Id = 10, Name = "Storm Squad",      Description = "A versatile unit specializing in rapid response and weather-related operations." },
                new Squad { Id = 11, Name = "Sabre Squad",      Description = "A highly trained unit specializing in close combat and hand-to-hand combat." },
                new Squad { Id = 12, Name = "Atlas Squad",      Description = "A unit of soldiers with incredible strength and endurance, capable of moving mountains." },
                new Squad { Id = 13, Name = "Omega Squad",      Description = "A team of soldiers equipped with cutting-edge technology and advanced weaponry." },
                new Squad { Id = 14, Name = "Blade Squad",      Description = "A group of highly skilled swordsmen, trained in the art of combat and swordplay." }
                );
            #endregion

            #region Supplies
            modelBuilder.Entity<Supply>().HasData(
                new Supply { Id = 1, Title = "NerfGun Ammo", HumanVisible = true, ZombieVisible = false, MapId = 1, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.AMMO, Amount = 40 },
                new Supply { Id = 2, Title = "NerfGun",      HumanVisible = true, ZombieVisible = false, MapId = 1, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.NERFGUN, Amount = 10 },
                new Supply { Id = 3, Title = "Grenades",     HumanVisible = true, ZombieVisible = false, MapId = 1, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.GENERADE, Amount = 10 },

                new Supply { Id = 4, Title = "NerfGun Ammo", HumanVisible = true, ZombieVisible = false, MapId = 2, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.AMMO, Amount = 40 },
                new Supply { Id = 5, Title = "NerfGun", HumanVisible = true, ZombieVisible = false, MapId = 2, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.NERFGUN, Amount = 10 },
                new Supply { Id = 6, Title = "Grenades", HumanVisible = true, ZombieVisible = false, MapId = 2, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.GENERADE, Amount = 10 },

                new Supply { Id = 7, Title = "NerfGun Ammo", HumanVisible = true, ZombieVisible = false, MapId = 3, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.AMMO, Amount = 40 },
                new Supply { Id = 8, Title = "NerfGun", HumanVisible = true, ZombieVisible = false, MapId = 3, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.NERFGUN, Amount = 10 },
                new Supply { Id = 9, Title = "Grenades", HumanVisible = true, ZombieVisible = false, MapId = 3, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.GENERADE, Amount = 10 },

                new Supply { Id = 10, Title = "NerfGun Ammo", HumanVisible = true, ZombieVisible = false, MapId = 4, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.AMMO, Amount = 40 },
                new Supply { Id = 11, Title = "NerfGun", HumanVisible = true, ZombieVisible = false, MapId = 4, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.NERFGUN, Amount = 10 },
                new Supply { Id = 12, Title = "Grenades", HumanVisible = true, ZombieVisible = false, MapId = 4, BeginTime = new DateTime(2023, 03, 11, 09, 30, 00), EndTime = new DateTime(2023, 03, 11, 10, 00, 00), Latitude = 55.643243, Longitude = 12.270559, Drop = ItemType.GENERADE, Amount = 10 }
                );
            #endregion

            #region Users
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, NickName = "Rainbow", FirstName = "Ethan", LastName = "Johnson" },
                new User { Id = 2, NickName = "Kratos", FirstName = "Olivia", LastName = "Brown" },
                new User { Id = 3, NickName = "Sub-Zero", FirstName = "Liam", LastName = "Martinez" },
                new User { Id = 4, NickName = "Link", FirstName = "Emma", LastName = "Rodriguez" },
                new User { Id = 5, NickName = "Zelda", FirstName = "Noah", LastName = "Lee" },
                new User { Id = 6, NickName = "Master Chief", FirstName = "Ava", LastName = "Davis" },
                new User { Id = 7, NickName = "Solid Snake", FirstName = "William", LastName = "Wilson" },
                new User { Id = 8, NickName = "AlbertWesker", FirstName = "Sophia", LastName = "Thompson" },
                new User { Id = 9, NickName = "Cloud", FirstName = "James", LastName = "White" },
                new User { Id = 10, NickName = "Aloy", FirstName = "Mia", LastName = "Hernandez" },
                new User { Id = 11, NickName = "Trevor", FirstName = "Lucas", LastName = "Garcia" },
                new User { Id = 12, NickName = "Dante", FirstName = "Isabella", LastName = "Smith" },
                new User { Id = 13, NickName = "LaraCroft", FirstName = "Mason", LastName = "Brown" },
                new User { Id = 14, NickName = "John Marston", FirstName = "Sophia", LastName = "Gonzalez" },
                new User { Id = 15, NickName = "Sam Fisher", FirstName = "Logan", LastName = "Perez" },
                new User { Id = 16, NickName = "Max Payne", FirstName = "Chloe", LastName = "Davis" },
                new User { Id = 17, NickName = "Nemesis", FirstName = "Benjamin", LastName = "Wilson" },
                new User { Id = 18, NickName = "Ellie", FirstName = "Avery", LastName = "Taylor" },
                new User { Id = 19, NickName = "Commander Shepard", FirstName = "Evelyn", LastName = "Anderson" },
                new User { Id = 20, NickName = "Jill Valentine", FirstName = "Daniel", LastName = "Hernandez" },
                new User { Id = 21, NickName = "Leon S. Kennedy", FirstName = "Caleb", LastName = "Moore" },
                new User { Id = 22, NickName = "Nathan Drake", FirstName = "Abigail", LastName = "Gomez" },
                new User { Id = 23, NickName = "Sonic the Hedgehog", FirstName = "Ethan", LastName = "Campbell" },
                new User { Id = 24, NickName = "Ezio Auditore", FirstName = "Hannah", LastName = "Parker" },
                new User { Id = 25, NickName = "Geralt of Rivia", FirstName = "Alexander", LastName = "Allen" },
                new User { Id = 26, NickName = "Samus Aran", FirstName = "Madison", LastName = "King" },
                new User { Id = 27, NickName = "Raiden", FirstName = "Joseph", LastName = "Wright" },
                new User { Id = 28, NickName = "Ezra", FirstName = "Avery", LastName = "Scott" },
                new User { Id = 29, NickName = "Daenerys", FirstName = "Sofia", LastName = "Green" },
                new User { Id = 30, NickName = "Neo", FirstName = "Christopher", LastName = "Baker" },
                new User { Id = 31, NickName = "Trinity", FirstName = "Ella", LastName = "Adams" },
                new User { Id = 32, NickName = "Blade", FirstName = "Joshua", LastName = "Nelson" },
                new User { Id = 33, NickName = "Ripley", FirstName = "Avery", LastName = "Carter" },
                new User { Id = 34, NickName = "Arya", FirstName = "Grace", LastName = "Mitchell" },
                new User { Id = 35, NickName = "Wolverine", FirstName = "Samuel", LastName = "Turner" },
                new User { Id = 36, NickName = "Leia", FirstName = "Victoria", LastName = "Phillips" },
                new User { Id = 37, NickName = "Spartan", FirstName = "David", LastName = "Campbell" },
                new User { Id = 38, NickName = "Katniss", FirstName = "Aria", LastName = "Garcia" },
                new User { Id = 39, NickName = "Nikita", FirstName = "Daniel", LastName = "Cruz" },
                new User { Id = 40, NickName = "Triss", FirstName = "Brianna", LastName = "Perez" },
                new User { Id = 41, NickName = "Indiana", FirstName = "Joseph", LastName = "Bailey" },
                new User { Id = 42, NickName = "Rip Hunter", FirstName = "Audrey", LastName = "Evans" },
                new User { Id = 43, NickName = "Kraven", FirstName = "Jacob", LastName = "Rivera" },
                new User { Id = 44, NickName = "Harley", FirstName = "Avery", LastName = "Cooper" },
                new User { Id = 45, NickName = "Mystique", FirstName = "Natalie", LastName = "Reyes" },
                new User { Id = 46, NickName = "Hannibal", FirstName = "Elijah", LastName = "Collins" },
                new User { Id = 47, NickName = "Xena", FirstName = "Elizabeth", LastName = "Lee" },
                new User { Id = 48, NickName = "Bane", FirstName = "Benjamin", LastName = "Gonzalez" },
                new User { Id = 49, NickName = "Riddick", FirstName = "Aaliyah", LastName = "Martinez" },
                new User { Id = 50, NickName = "Morpheus", FirstName = "Ethan", LastName = "Walker" },
                new User { Id = 51, NickName = "Gambit", FirstName = "Avery", LastName = "Hall" },
                new User { Id = 52, NickName = "Violet", FirstName = "Emily", LastName = "Allen" },
                new User { Id = 53, NickName = "Nathan Hale", FirstName = "William", LastName = "Garcia" },
                new User { Id = 54, NickName = "Evelyn Salt", FirstName = "Grace", LastName = "Wilson" },
                new User { Id = 55, NickName = "Spartacus", FirstName = "Gabriel", LastName = "Anderson" },
                new User { Id = 56, NickName = "Alice Abernathy", FirstName = "Chloe", LastName = "Taylor" },
                new User { Id = 57, NickName = "Captain John Price", FirstName = "Samuel", LastName = "Brown" },
                new User { Id = 58, NickName = "Elsa", FirstName = "Lily", LastName = "Moore" },
                new User { Id = 59, NickName = "Marcus Fenix", FirstName = "David", LastName = "Lopez" },
                new User { Id = 60, NickName = "Lena Oxton", FirstName = "Sofia", LastName = "Johnson" },
                new User { Id = 61, NickName = "Chris Redfield", FirstName = "Noah", LastName = "Davis" },
                new User { Id = 62, NickName = "Doomguy", FirstName = "Avery", LastName = "Harris" },
                new User { Id = 63, NickName = "Katniss Everdeen", FirstName = "Mia", LastName = "Thomas" },
                new User { Id = 64, NickName = "Jason Brody", FirstName = "Daniel", LastName = "Allen" },
                new User { Id = 65, NickName = "Mako Mori", FirstName = "Aria", LastName = "Young" },
                new User { Id = 66, NickName = "Ezra Bridger", FirstName = "Jacob", LastName = "Nelson" },
                new User { Id = 67, NickName = "Rey", FirstName = "Charlotte", LastName = "Sanchez" },
                new User { Id = 68, NickName = "Geralt of Rivia", FirstName = "Logan", LastName = "Parker" },
                new User { Id = 69, NickName = "Wonder Woman", FirstName = "Olivia", LastName = "Mitchell" },
                new User { Id = 70, NickName = "Altair Ibn-La'Ahad", FirstName = "Caleb", LastName = "Clark" }
                );
            #endregion
        }
    }
}
