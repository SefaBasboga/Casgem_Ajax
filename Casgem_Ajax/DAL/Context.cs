using Microsoft.EntityFrameworkCore;

namespace Casgem_Ajax.DAL
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-H5NLS4J;Initial Catalog=CasgemAjaxDb; integrated Security=true;TrustServerCertificate=true;");
  
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
