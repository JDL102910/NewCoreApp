using Microsoft.AspNetCore.Mvc.RazorPages;
using NewCoreApp.Models;
using NewCoreApp.Services;

namespace NewCoreApp.Pages
{
    public class InventoryModel : PageModel
    {
        private readonly Inventory _inventory;

        public List<InventoryItem> InventoryItems { get; set; } = new();

        public InventoryModel(Inventory inventory)
        {
            _inventory = inventory;
        }

        public void OnGet()
        {
            InventoryItems = _inventory.GetItems();
        }
    }
}
