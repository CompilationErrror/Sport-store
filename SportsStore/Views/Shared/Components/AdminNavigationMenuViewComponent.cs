using Microsoft.AspNetCore.Mvc;

namespace SportsStore.Views.Shared.Components
{
    public class AdminNavigationMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.Selection = Request.Path.Value ?? "Products";

            return View(new string[] { "Orders", "Products" });
        }
    }
}
