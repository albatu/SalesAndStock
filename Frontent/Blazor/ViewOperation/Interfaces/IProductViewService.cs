using Blazor2.Models.Product;
using Entities.Entities;

namespace Blazor2.ViewOperation.Interfaces
{
    public interface IProductViewService
    {
        List<ProductViewModel> Categories();
        List<ProductViewModel> BrandListing();
        List<ProductViewModel> GetProductList();
        List<ProductViewModel> TaxList();
        Product TEntity(ProductViewModel entity);
        List<ProductViewModel> Search(string text);
        

    }
}
