namespace FoodApi.Models
{
    public class Product
    {
        public uint ID { get; set; }
        public string Name { get; set; }
        public uint Price { get; set; }

        public string ImageUrl { get; set; }

        public Status Status { get; set; }

        public Store Store { get; set; }
    }

    public class ProductContext : DataContext
    {
        public DbSet<Order> Orders { get; set; }
    }
}