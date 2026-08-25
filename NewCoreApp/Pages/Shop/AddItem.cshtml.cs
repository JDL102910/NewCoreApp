using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewCoreApp.Services;
using System.Runtime.CompilerServices;

namespace NewCoreApp.Pages.Shop
{
    public class AddItemModel : PageModel
    {

        private Inventory inventory;

        public AddItemModel(Inventory inventory)
        {
            this.inventory = inventory;
        }

        public string? Name { get; set; }
        
        public decimal Price { get; set; }

        public string? Category { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
        }
    }
}
