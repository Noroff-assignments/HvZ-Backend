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

            #region Chats
            modelBuilder.Entity<Chat>().HasData(
                new Chat { Id = 1, Message = "Welcome to the game of Humans vs. Zombies! This is the global chat where everyone can communicate with each other.", Mode = ChatMode.GLOBAL, TimeStamp = new DateTime(2023, 1, 21, 13, 20, 00), GameId = 1},
                new Chat { Id = 2, Message = "Remember to play fair and respect the rules of the game.", Mode = ChatMode.GLOBAL, TimeStamp = new DateTime(2023, 1, 21, 13, 20, 10), GameId = 1},
                new Chat { Id = 3, Message = "Humans, stay alert and work together to survive the zombie apocalypse.", Mode = ChatMode.GLOBAL, TimeStamp = new DateTime(2023, 1, 21, 13, 20, 20), GameId = 1 },
                new Chat { Id = 4, Message = "Zombies, work together to infect as many humans as possible and turn them into zombies.", Mode = ChatMode.GLOBAL, TimeStamp = new DateTime(2023, 1, 21, 13, 20, 30), GameId = 1 },
                new Chat { Id = 5, Message = "Hey, everyone! Good luck to both the human and zombie factions!", Mode = ChatMode.GLOBAL, TimeStamp = new DateTime(2023, 1, 21, 13, 30, 52), GameId = 1, PlayerId=1 },
                new Chat { Id = 6, Message = "Thanks, Rainbow! May the best team win!", Mode = ChatMode.GLOBAL, TimeStamp = new DateTime(2023, 1, 21, 13, 31, 17), GameId = 1, PlayerId = 2 },
                new Chat { Id = 7, Message = "I'm ready to survive this apocalypse!", Mode = ChatMode.GLOBAL, TimeStamp = new DateTime(2023, 1, 21, 13, 33, 36), GameId = 1, PlayerId = 3 },
                new Chat { Id = 8, Message = "I'm ready to eat some brains!", Mode = ChatMode.GLOBAL, TimeStamp = new DateTime(2023, 1, 21, 13, 35, 21), GameId = 1, PlayerId = 4 },
                new Chat { Id = 8, Message = "Remember, let's keep this game fun and respectful for everyone.", Mode = ChatMode.GLOBAL, TimeStamp = new DateTime(2023, 1, 21, 14, 12, 07), GameId = 1, PlayerId = 5 },


                new Chat { Id = 8, Message = "Hey humans, this is the chat for our faction. Let's work together to survive and outsmart the zombies.", Mode = ChatMode.HUMAN, TimeStamp = new DateTime(2023, 1, 21, 13, 21, 10), GameId = 1 },
                new Chat { Id = 8, Message = "Remember to stock up on supplies and weapons, and be aware of your surroundings.", Mode = ChatMode.HUMAN, TimeStamp = new DateTime(2023, 1, 21, 13, 21, 15), GameId = 1 },
                new Chat { Id = 8, Message = "If you see a zombie, try to avoid them or take them down with your weapons.", Mode = ChatMode.HUMAN, TimeStamp = new DateTime(2023, 1, 21, 13, 21, 20), GameId = 1 },
                new Chat { Id = 8, Message = "Hey, humans! Let's stick together and watch each other's backs.", Mode = ChatMode.HUMAN, TimeStamp = new DateTime(2023, 1, 21, 13, 21, 30), GameId = 1 },
                new Chat { Id = 8, Message = "Absolutely. We need to be careful and avoid any unnecessary risks.", Mode = ChatMode.HUMAN, TimeStamp = new DateTime(2023, 1, 21, 13, 21, 30), GameId = 1 },
                new Chat { Id = 8, Message = "Does anyone know where we can find some more supplies?", Mode = ChatMode.HUMAN, TimeStamp = new DateTime(2023, 1, 21, 13, 21, 30), GameId = 1 },


                new Chat { Id = 5, Message = "Welcome zombies, this is our chat. Let's work together to infect as many humans as we can.", Mode = ChatMode.ZOMBIE, TimeStamp = new DateTime(2023, 1, 21, 13, 21, 40), GameId = 1 },
                new Chat { Id = 6, Message = "Remember to coordinate and strategize. Don't just mindlessly chase after humans.", Mode = ChatMode.ZOMBIE, TimeStamp = new DateTime(2023, 1, 21, 13, 21, 50), GameId = 1 },
                new Chat { Id = 7, Message = "If you see a lone human, don't be afraid to call for backup from your fellow zombies.", Mode = ChatMode.ZOMBIE, TimeStamp = new DateTime(2023, 1, 21, 13, 22, 00), GameId = 1 },
                new Chat { Id = 8, Message = "Let's show the humans what a real zombie apocalypse looks like!", Mode = ChatMode.ZOMBIE, TimeStamp = new DateTime(2023, 1, 21, 13, 22, 10), GameId = 1 },
                new Chat { Id = 8, Message = "Zombies, listen up! We need to coordinate our attacks and take down the humans one by one.", Mode = ChatMode.ZOMBIE, TimeStamp = new DateTime(2023, 1, 21, 13, 22, 10), GameId = 1 },
                new Chat { Id = 8, Message = "I agree. We can't let them overpower us.", Mode = ChatMode.ZOMBIE, TimeStamp = new DateTime(2023, 1, 21, 13, 22, 10), GameId = 1 },
                new Chat { Id = 8, Message = "I just saw a group of humans near the Science Building. Let's go get them!", Mode = ChatMode.ZOMBIE, TimeStamp = new DateTime(2023, 1, 21, 13, 22, 10), GameId = 1 },
                new Chat { Id = 8, Message = "Wait, hold on. We should wait for backup and attack them when they least expect it.", Mode = ChatMode.ZOMBIE, TimeStamp = new DateTime(2023, 1, 21, 13, 22, 10), GameId = 1 },



                new Chat { Id = 8, Message = "Hey squad, this is our chat where we can communicate with each other more easily.", Mode = ChatMode.SQUAD, TimeStamp = new DateTime(2023, 1, 21, 13, 42, 10), GameId = 1 },
                new Chat { Id = 8, Message = "Let's coordinate our movements and stick together for safety.", Mode = ChatMode.SQUAD, TimeStamp = new DateTime(2023, 1, 21, 13, 42, 30), GameId = 1 },
                new Chat { Id = 8, Message = "Humans, if you see a zombie, call for backup from your squadmates.", Mode = ChatMode.SQUAD, TimeStamp = new DateTime(2023, 1, 21, 13, 42, 40), GameId = 1 },
                new Chat { Id = 8, Message = "Zombies, if you spot a group of humans, let your squadmates know so you can coordinate an attack.", Mode = ChatMode.SQUAD, TimeStamp = new DateTime(2023, 1, 21, 13, 43, 10), GameId = 1 },
                new Chat { Id = 8, Message = "Remember to have each other's backs and work together to win the game!", Mode = ChatMode.SQUAD, TimeStamp = new DateTime(2023, 1, 21, 13, 43, 25), GameId = 1 },
                new Chat { Id = 8, Message = "Squad, we need to move quickly and avoid drawing attention to ourselves.", Mode = ChatMode.SQUAD, TimeStamp = new DateTime(2023, 1, 21, 13, 32, 10), GameId = 1 },
                new Chat { Id = 8, Message = "Agreed. We don't want to get surrounded by zombies.", Mode = ChatMode.SQUAD, TimeStamp = new DateTime(2023, 1, 21, 13, 32, 10), GameId = 1 },
                new Chat { Id = 8, Message = "I found a shortcut through the parking lot that can lead us to the next safe zone.", Mode = ChatMode.SQUAD, TimeStamp = new DateTime(2023, 1, 21, 13, 32, 10), GameId = 1 },
                new Chat { Id = 8, Message = "Nice one, Player3! Let's go that way and stay alert.", Mode = ChatMode.SQUAD, TimeStamp = new DateTime(2023, 1, 21, 13, 32, 10), GameId = 1 },
                new Chat { Id = 8, Message = "Zombies incoming! Let's take them down together!", Mode = ChatMode.SQUAD, TimeStamp = new DateTime(2023, 1, 21, 13, 32, 10), GameId = 1 }
                );
            #endregion

            #region Games
            modelBuilder.Entity<Game>().HasData(

                );
            #endregion

            #region Kills
            modelBuilder.Entity<Kill>().HasData(

                );
            #endregion

            #region Maps
            modelBuilder.Entity<Map>().HasData(

                );
            #endregion

            #region Missions
            modelBuilder.Entity<Mission>().HasData(

                );
            #endregion

            #region Players
            modelBuilder.Entity<Player>().HasData(

                );
            #endregion

            #region Safezones
            modelBuilder.Entity<Safezone>().HasData(

                );
            #endregion

            #region Squads
            modelBuilder.Entity<Squad>().HasData(

                );
            #endregion

            #region Supplies
            modelBuilder.Entity<Supply>().HasData(

                );
            #endregion

            #region Users
            modelBuilder.Entity<User>().HasData(

                );
            #endregion
        }
    }
}
