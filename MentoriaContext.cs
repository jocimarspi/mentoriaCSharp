using Microsoft.EntityFrameworkCore;

namespace mentoring
{
    public class MentoriaContext : DbContext
    {
        public virtual DbSet<Instituition> Instituitions { get; set; }
        public virtual DbSet<Student>  Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;User Id=root;Password=root;Database=aconcept");
            }
        }
    }
}