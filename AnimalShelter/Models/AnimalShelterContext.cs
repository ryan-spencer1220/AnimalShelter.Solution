
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Animal>()
              .HasData(
                  new Animal { AnimalId = 1, Name = "Walter", Species = "Dog", Age = 7, Gender = "Female" },
                  new Animal { AnimalId = 2, Name = "Hudson", Species = "Dog", Age = 1, Gender = "Female" },
                  new Animal { AnimalId = 3, Name = "Charlie", Species = "Cat", Age = 2, Gender = "Female" },
                  new Animal { AnimalId = 4, Name = "Bob", Species = "Cat", Age = 4, Gender = "Male" },
                  new Animal { AnimalId = 5, Name = "Margaret", Species = "Cat", Age = 2, Gender = "Male" }
              );
        }

        public DbSet<Animal> Animals { get; set; }
    }
}