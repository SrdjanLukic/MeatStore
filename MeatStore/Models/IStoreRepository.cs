using System.Linq;

namespace MeatStore.Models
{
   public interface IStoreRepository
    {
        IQueryable<Product> GetProducts();
        void SaveProduct(Product p);
        void CreateProduct(Product p);
        void DeleteProduct(Product p);

    }
}
