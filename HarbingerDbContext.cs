using Microsoft.EntityFrameworkCore;
namespace StarWars.Models
{
	public class HarbingerDbContext : DbContext
	{
        public DbSet<Character> Characters {get; set; }
        public DbSet<Quest> Quests {get; set; }
		public HarbingerDbContext (DbContextOptions<HarbingerDbContext> options) : base(options)
		{
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seed character data
            modelBuilder.Entity<Character>().HasData(
                new Character { CharacterId =1, Name = "Rey Skywalker", Species = "Human", Affiliation = "Jedi"},
                new Character { CharacterId =2, Name = "Fin", Species = "Human", Affiliation = "Scoundrel"},
                new Character { CharacterId =3, Name = "Po Dameron", Species = "Human", Affiliation = "Rebel"},
                new Character { CharacterId =4, Name = "Metra Surik", Species = "Human", Affiliation = "Exile"},
                new Character { CharacterId =5, Name = "Zaalbarr", Species = "Wookie", Affiliation = "Scout"},
                new Character { CharacterId =6, Name = "Greedo", Species = "Rodian", Affiliation = "Bounty Hunter"},
                new Character { CharacterId =7, Name = "Hk-47", Species = "Droid", Affiliation = "Assassin"},
                new Character { CharacterId =8, Name = "Bralor Starkiller", Species = "Human", Affiliation = "Mandalorian"},
                new Character { CharacterId =9, Name = "Ahsoka Tano", Species = "Twilek", Affiliation = "Jedi"},
                new Character { CharacterId =10, Name = "Din Djarin", Species = "Human", Affiliation = "Mandalorian"},
                new Character { CharacterId =11, Name = "Sheev Palpatine", Species = "Human", Affiliation = "Sith Lord"},
                new Character { CharacterId =12, Name = "Darth Malak", Species = "Human", Affiliation = "Sith Lord"},
                new Character { CharacterId =13, Name = "Cal Kestis", Species = "Human", Affiliation = "Jedi"},
                new Character { CharacterId =14, Name = "Master Vrook", Species = "Human", Affiliation = "Jedi"},
                new Character { CharacterId =15, Name = "Sleemo Lacerus", Species = "Zabraak", Affiliation = "Marauder"},
                new Character { CharacterId =16, Name = "Atris", Species = "Human", Affiliation = "Jedi Historian"},
                new Character { CharacterId =17, Name = "Quade Lancaster", Species = "Human", Affiliation = "Jedi"},
                new Character { CharacterId =18, Name = "Boba Fett", Species = "Human", Affiliation = "Clone"},
                new Character { CharacterId =19, Name = "Carth Onasi", Species = "Human", Affiliation = "General"},
                new Character { CharacterId =20, Name = "Mission Vao", Species = "Twilek", Affiliation = "Scoundrel"},
                new Character { CharacterId =21, Name = "Canderous Ordo", Species = "Human", Affiliation = "Mandalorian"},
                new Character { CharacterId =22, Name = "Bo-Katan Kryze", Species = "Human", Affiliation = "Mandalorian"},
                new Character { CharacterId =23, Name = "Jek Porkins", Species = "Human", Affiliation = "Pilot"},
                new Character { CharacterId =24, Name = "Piett", Species = "Human", Affiliation = "Sith Admiral"},
                new Character { CharacterId =25, Name = "Trilla", Species = "Human", Affiliation = "Inquistor"}
            );
            //seed quest data
            modelBuilder.Entity<Quest>().HasData(
                new Quest { QuestId = 1, Title = "Jaku", Description = "Quest begins where Rey has a premonition", Type ="Main Quest" },
                new Quest { QuestId = 2, Title = "Academy on Telos", Description = "Char Meets Master Atris", Type ="Main Quest" },
                new Quest { QuestId = 3, Title = "Memories Unlimited", Description = "Char travels to Jedha in search of holocron", Type ="Main Quest" },
                new Quest { QuestId = 4, Title = "Trouble on Tanalor", Description = "Char comes face to face with an inquisitor", Type ="Main Quest" },
                new Quest { QuestId = 5, Title = "Back to Jaku", Description = "Rey meets char outside shuttle for news", Type ="Main Quest" },
                new Quest { QuestId = 6, Title = "A disturbance in the force", Description = "Char begins reliving inquistor standoff", Type ="Main Quest" },
                new Quest { QuestId = 7, Title = "Palpatine Returns", Description = "The spirit of palpatine endures", Type ="Main Quest" },
                new Quest { QuestId = 8, Title = "Rebel Forces Engage Defectors", Description = "beyond the astroid belt a star destroyer is found", Type ="Main Quest" },
                new Quest { QuestId = 9, Title = "Po Dameron crash lands on Dxun", Description = "Po meets Meetra Surik a Jedi exile living among mandalorians", Type ="Main Quest" },
                new Quest { QuestId = 10, Title = "Jek Porkins pulls forces back", Description = "surviving imperials flee to planet beneath burning star destroyer", Type ="Main Quest" },
                new Quest { QuestId = 11, Title = "Piett calls for reinforcements", Description = "An unexpected answer from a new threat", Type ="Main Quest" },
                new Quest { QuestId = 12, Title = "The Leviathan", Description = "Darth Malak emerges from the outer rim with inquisitors", Type ="Main Quest" },
                new Quest { QuestId = 13, Title = "Dxun Jungle", Description = "Po and Meetra search for imperial crash landers", Type ="Main Quest" },
                new Quest { QuestId = 14, Title = "Back to Telos", Description = "Atris continues Quades jedi training", Type ="Side Quest" },
                new Quest { QuestId = 15, Title = "An Old Order", Description = "Rey begins searching for the new sith threat", Type ="Main Quest" }
            );
        }
    }
}


