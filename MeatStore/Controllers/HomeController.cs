using Microsoft.AspNetCore.Mvc;
using MeatStore.Models;
using MeatStore.Models.ViewModels;
using System.Linq;

namespace MeatStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int PageSize = 4;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index(string category, int productPage = 1)
        {
            ProductsListViewModel productsListViewModel = new ProductsListViewModel();

            productsListViewModel.Products = repository.GetProducts()
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.ProductID)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize);

            int totalItems;
            if (string.IsNullOrEmpty(category))
                totalItems = repository.GetProducts().Count();
            else
                totalItems = repository.GetProducts().Where(e =>
                    e.Category == category).Count();

            productsListViewModel.PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = totalItems
            };

            productsListViewModel.CurrentCategory = category;

            return View(productsListViewModel);
        }

    }
}


