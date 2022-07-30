using System.Collections.Generic;

namespace FoodApi.Models
{
    public class Customer
    {
        public uint ID { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
    }

    public class CustomerContext : DataContext
    {
        public DbSet<Customer> Customers { get; set; }        
    }
}