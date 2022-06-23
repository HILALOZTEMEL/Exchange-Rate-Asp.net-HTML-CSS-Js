using Microsoft.EntityFrameworkCore;

namespace finalSerbestPiyasaDoviz.Models
{
    public class CustomerContext : DbContext
    {
       
        public CustomerContext(DbContextOptions<CustomerContext> options)
         : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
                    {
                        modelBuilder.Entity<Customer>().HasData(
                        new Customer
                        {
                            CustomerId = 1,
                            UserName = "Hilal",
                            DolarTahmin = "18.6"
                            
                        },
                        new Customer
                        {
                            CustomerId = 2,
                            UserName = "Zehra",
                            DolarTahmin = "13.11",
                            
                        },
                        new Customer
                        {
                            CustomerId = 3,
                            UserName = "Alihan",
                            DolarTahmin = "15.96"
                            
                        }
                        );
        }
    }
}



