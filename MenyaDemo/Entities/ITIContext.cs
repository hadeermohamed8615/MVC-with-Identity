using MenyaDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace MenyaDemo.Entities
{
    public class ITIContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Avaialble only with Core
            //optionsBuilder.UseSqlServer("Server = .; Database=MinaiMVC ;Trust-Connection = true ; Encrypt = False");
            //avaliable with Framework and Core
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MinaiMVC;Integrated Security=True;Encrypt=False");
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
    }
}
