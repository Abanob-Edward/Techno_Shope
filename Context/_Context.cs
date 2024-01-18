using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace Context
{
    public class _Context: DbContext
    {
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Onion;Integrated Security=True;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
        }
        public virtual DbSet<Student> Students { get; set; }
    }
}
