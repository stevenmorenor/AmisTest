using AmisTest.Models;
using Microsoft.EntityFrameworkCore;

namespace AmisTest.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Models.Form> Forms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasMany(p => p.Forms)
                .WithOne(p => p.Person)
                .HasForeignKey(p => p.PersonId);
            modelBuilder.Entity<Models.Question>()
                .HasMany(p => p.Forms)
                .WithOne(p => p.Question)
                .HasForeignKey(p => p.QuestionId);

            modelBuilder.Entity<Person>()
                .HasMany(p => p.Questions)
                .WithMany(p => p.People)
                .UsingEntity<Models.Form>(
                    j => j
                        .HasOne(p => p.Question)
                        .WithMany(p => p.Forms)
                        .HasForeignKey(p => p.QuestionId),
                    j => j
                        .HasOne(p => p.Person)
                        .WithMany(p => p.Forms)
                        .HasForeignKey(p => p.PersonId),
                    j =>
                    {
                        j.HasKey(p => p.FormId);
                    }
                );
        }
    }
}
