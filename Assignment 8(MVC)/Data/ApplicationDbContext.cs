using Models;
using Microsoft.EntityFrameworkCore;

namespace _1.Data
{
   public  class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        
            public DbSet<Student> Student {get; set;}

            public DbSet<Teacher> Teacher {get; set;}
    }
}