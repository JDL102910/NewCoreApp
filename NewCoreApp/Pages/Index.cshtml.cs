using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewCoreApp.Models;
using NewCoreApp.Services;

namespace NewCoreApp.Pages
{
    public class IndexModel : PageModel
    {

        private Inventory inventory;

        public IndexModel(Inventory inventory)
        {
            this.inventory = inventory;
        }

        public void OnGet()
        {

        }
    }
}
