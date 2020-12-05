using GenericRepositoryExample.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryExample.Data.Configs
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>()
                .HasData(
                new Artist() { Id = 1, Name = "Linkin Park" },
                new Artist() { Id = 2, Name = "Iron Maiden" },
                new Artist() { Id = 3, Name = "Flogging Molly" },
                new Artist() { Id = 4, Name = "Red Hot Chilli Peppers" }
                );

            //modelBuilder.Entity<Artist>().HasOne();

            modelBuilder.Entity<Music>()
                .HasData(
                new Music() { ArtistId = 1, Name = "In The End", Id = 1 },
                new Music() { ArtistId = 1, Name = "Numb", Id = 2 },
                new Music() { ArtistId = 1, Name = "Breaking The Habit", Id = 3 },
                new Music() { ArtistId = 2, Name = "Fear of the dark", Id = 4 },
                new Music() { ArtistId = 2, Name = "Number of the beast", Id = 5 },
                new Music() { ArtistId = 2, Name = "The Trooper", Id = 6 },
                new Music() { ArtistId = 3, Name = "What''s left of the flag", Id = 7 },
                new Music() { ArtistId = 3, Name = "Drunken Lullabies", Id = 8 },
                new Music() { ArtistId = 3, Name = "If I Ever Leave this World Alive", Id = 9 },
                new Music() { ArtistId = 4, Name = "Californication", Id = 10 },
                new Music() { ArtistId = 4, Name = "Tell Me Baby", Id = 11 },
                new Music() { ArtistId = 4, Name = "Parallel Universe", Id = 12 }
                );
        }
    }
}
