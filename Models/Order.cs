using System.Collections.Generic;

namespace FoodApi.Models
{
    public class Order
    {
        public uint ID { get; set; }
        public uint Total { get; set; }
        public Store Store { get; set; }
        public List<Product> Products { get; set; }
    }

    public class OrderContext : DataContext {
        public DbSet<Order> Orders { get; set; }
    }
}