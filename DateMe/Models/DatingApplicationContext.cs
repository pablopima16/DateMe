using Microsoft.EntityFrameworkCore;

namespace DateMe.Models
{
    public class DatingApplicationContext :DbContext
    {
        public DatingApplicationContext(DbContextOptions<DatingApplicationContext> options): base (options) //COnstructor
        { 
        }

        public DbSet <Application> Applications { get; set; } //Name of the table
    }
}
