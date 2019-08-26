using Microsoft.EntityFrameworkCore;
using Nota10.Models;

namespace Nota10.Data
{
    public class Nota10Context : DbContext
    {
       public Nota10Context(DbContextOptions<Nota10Context> options) : base(options)
       {
       } 

       public DbSet<Instituition> Instituitions { get; set; }
       public DbSet<Classroom> Classrooms { get; set; }
       public DbSet<Student> Students {get; set;}       
    }
}