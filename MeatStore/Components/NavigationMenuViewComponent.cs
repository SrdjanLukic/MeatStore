using MeatStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace MeatStore.Components
{
    public class NavigationMenuViewComponent: ViewComponent
    {
        private IStoreRepository repository;

        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.GetProducts()
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
