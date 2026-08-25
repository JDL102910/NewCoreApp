using NewCoreApp.Models;

namespace NewCoreApp.Services
{
    public class Inventory
    {
        private List<InventoryItem> items = new List<InventoryItem>();

        public void AddItem(InventoryItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(InventoryItem item)
        {
            items.Remove(item);
        }

        public List<InventoryItem> GetItems()
        {
            return items;
        }
    }
}
