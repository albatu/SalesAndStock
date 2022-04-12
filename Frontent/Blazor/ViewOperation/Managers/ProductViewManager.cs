using Blazor2.Models.Product;
using Blazor2.ViewOperation.Interfaces;
using Business.Interfaces;
using Entities.Entities;

namespace Blazor2.ViewOperation.Managers
{
    public class ProductViewManager : IProductViewService
    {
        private IBrandService _brandService;
        private ICategoryService _categoryService;
        private IProductService _productService;
        private ITaxService _taxService;

       

        public ProductViewManager(IBrandService brandService, ICategoryService categoryService, 
            IProductService productService, ITaxService taxService)
        {
            _taxService = taxService;
            _brandService = brandService;
            _categoryService = categoryService;
            _productService = productService;
        }

        public List<ProductViewModel> BrandListing()
        {
            List<ProductViewModel> brandListing = new List<ProductViewModel>();
            foreach (var item in _brandService.GetAll())
            {
                brandListing.Add(new ProductViewModel
                {
                    BrandId = item.Id,
                    BrandName = item.Name,
                    BrandCompanyRepresentative = item.CompanyRepresentative,
                    BrandPhone = item.Phone
                });
            }
            return brandListing;
        }

        public List<ProductViewModel> Categories()
        {
            List<ProductViewModel> categories = new List<ProductViewModel>();
            foreach (var item in _categoryService.GetAll())
            {
                categories.Add(new ProductViewModel
                {
                    CategoryId = item.Id,
                    CategoryName = item.Name
                });
            }
            return categories;
        }

        public List<ProductViewModel> GetProductList()
        {
            List<ProductViewModel> productListing = new List<ProductViewModel>();
            foreach (var item in _productService.GetAll())
            {
                productListing.Add(new ProductViewModel
                {
                    Id = item.Id,
                    BrandId = item.BrandId.Id,
                    BrandName = item.BrandId.Name,
                    CategoryId = item.CategoryId.Id,
                    CategoryName = item.CategoryId.Name,
                    Price = item.Price,
                    ProductCode = item.ProductCode,
                    Description = item.Description,
                    Name = item.Name,
                    Length = item.Length,
                    Weight = item.Weight,
                    WeightUnit = item.WeightUnit,
                    TaxId = item.TaxId.Id,
                    TaxType = item.TaxId.TaxType,
                    BrandCompanyRepresentative = item.BrandId.CompanyRepresentative,
                    BrandPhone = item.BrandId.Phone,
                    Percentile = item.TaxId.Percentile,
                });
            }
            return productListing;
        }

        public List<ProductViewModel> Search(string text)
        {
            List<ProductViewModel> productListing = new List<ProductViewModel>();
            foreach (var item in _productService.Search(text))
            {
                productListing.Add(new ProductViewModel
                {
                    Id = item.Id,
                    BrandId = item.BrandId.Id,
                    BrandName = item.BrandId.Name,
                    CategoryId = item.CategoryId.Id,
                    CategoryName = item.CategoryId.Name,
                    Price = item.Price,
                    ProductCode = item.ProductCode,
                    Description = item.Description,
                    Name = item.Name,
                    Length = item.Length,
                    Weight = item.Weight,
                    WeightUnit = item.WeightUnit,
                    TaxId = item.TaxId.Id,
                    TaxType = item.TaxId.TaxType,
                    BrandCompanyRepresentative = item.BrandId.CompanyRepresentative,
                    BrandPhone = item.BrandId.Phone,
                    Percentile = item.TaxId.Percentile,
                });
            }
            return productListing;
        }

        public List<ProductViewModel> TaxList()
        {
            List<ProductViewModel> taxlist = new List<ProductViewModel>();
            foreach (var item in _taxService.GetAll())
            {
                taxlist.Add(new ProductViewModel
                {
                    TaxId = item.Id,
                    TaxType = item.TaxType,
                    Percentile = item.Percentile
                });
            }
            return taxlist;
        }

        public Product TEntity(ProductViewModel entity)
        {
            var brand = _brandService.GetById(entity.BrandId);
            var category = _categoryService.GetById(entity.CategoryId);
            var tax = _taxService.GetById(entity.TaxId);
            return new Product
            {

                Id = entity.Id,
                BrandId = brand,
                CategoryId = category,
                Description = entity.Description,
                Name = entity.Name,
                Price = entity.Price,
                ProductCode = entity.ProductCode,
                Length = entity.Length,
                Weight = entity.Weight,
                WeightUnit = entity.WeightUnit,
                TaxId = tax
                
            };
        }
    }
}
