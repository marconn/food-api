using System.Collections.Generic;

namespace FoodApi.Models
{
    public class Store
    {
        public uint ID { get; set; }
        public string Name { get; set; }
        public List<Product> Products {get; set; }
    }

    public class StoreContext: DataContext {
        public DbSet<Store> Orders { get; set; }
    }
}