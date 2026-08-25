namespace NewCoreApp.Models
{
    public class InventoryItem
    {
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public string? Category { get; set; }

        public InventoryItem(string? name, decimal? price, string? category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}
