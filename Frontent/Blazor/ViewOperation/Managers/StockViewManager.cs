using Blazor2.Models.Stock;
using Blazor2.ViewOperation.Interfaces;
using Business.Interfaces;
using Entities.Entities;

namespace Blazor2.ViewOperation.Managers
{
    public class StockViewManager : IStockViewService
    {
        private IStockService _stockService;
        private IProductService _productService;

        public StockViewManager(IStockService stockService, 
            IProductService productService)
        {
            _stockService = stockService;
            _productService = productService;
        }

        public List<StockViewModel> DateToDate(DateTime startDate, DateTime finishDate)
        {
            List<StockViewModel> list = new List<StockViewModel>();

            foreach (var item in _stockService.DateToDate(startDate,finishDate).OrderByDescending(p => p.StockDate))
            {
                list.Add(new StockViewModel
                {
                    Id = item.Id,
                    BrandsId = item.ProductId.BrandId.Id,
                    BrandsName = item.ProductId.BrandId.Name,
                    CategoryId = item.ProductId.CategoryId.Id,
                    CateogryName = item.ProductId.CategoryId.Name,
                    Piece = item.Piece,
                    ProductId = item.ProductId.Id,
                    ProductName = item.ProductId.Name,
                    StockDate = item.StockDate,
                    Price = item.ProductId.Price

                });
            }
            return list;
        }

        public StockViewModel GetById(int id)
        {
            var stock = _stockService.GetById(id);
            return new StockViewModel
           {
               Id = stock.Id,
               BrandsId = stock.ProductId.BrandId.Id,
               BrandsName = stock.ProductId.BrandId.Name,
               CategoryId = stock.ProductId.CategoryId.Id,
               CateogryName = stock.ProductId.CategoryId.Name,
               Piece = stock.ProductId.Id,
               ProductId = stock.ProductId.Id,
               ProductName = stock.ProductId.Name,
               StockDate = stock.StockDate
           };
        }

        public List<StockViewModel> GetProductList()
        {
            List<StockViewModel> productList = new List<StockViewModel>();

            foreach (var item in _productService.GetAll())
            {
                productList.Add(new StockViewModel
                {
                    BrandsId = item.BrandId.Id,
                    BrandsName = item.BrandId.Name,
                    CategoryId = item.CategoryId.Id,
                    CateogryName = item.CategoryId.Name,
                    ProductId = item.Id,
                    ProductName = item.Name
                });
            }
            return productList;
        }

        public List<StockViewModel> GetStockList()
        {
            List<StockViewModel> list = new List<StockViewModel>();

            foreach (var item in _stockService.GetAll().OrderByDescending(p => p.StockDate))
            {
                list.Add(new StockViewModel
                {
                    Id = item.Id,
                    BrandsId = item.ProductId.BrandId.Id,
                    BrandsName = item.ProductId.BrandId.Name,
                    CategoryId = item.ProductId.CategoryId.Id,
                    CateogryName = item.ProductId.CategoryId.Name,
                    Piece = item.Piece,
                    ProductId = item.ProductId.Id,
                    ProductName = item.ProductId.Name,
                    StockDate = item.StockDate,
                    Price = item.ProductId.Price

                });
            }
            return list;
        }

        public StockViewModel NewStock()
        {
            return new StockViewModel()
            {
                Id = 0,
                BrandsId = 0,
                BrandsName = "",
                CategoryId = 0,
                CateogryName = "",
                Price = 0,
                Piece = 0,
                ProductId = 0,
                ProductName = "",
                StockDate = DateTime.Now
            };
        }

        public List<StockViewModel> Paging(int skip, int take)
        {
            List<StockViewModel> list = new List<StockViewModel>();

            foreach (var item in _stockService.Paging(skip, take).OrderByDescending(p => p.StockDate))
            {
                list.Add(new StockViewModel
                {
                    Id = item.Id,
                    BrandsId = item.ProductId.BrandId.Id,
                    BrandsName = item.ProductId.BrandId.Name,
                    CategoryId = item.ProductId.CategoryId.Id,
                    CateogryName = item.ProductId.CategoryId.Name,
                    Piece = item.Piece,
                    ProductId = item.ProductId.Id,
                    ProductName = item.ProductId.Name,
                    StockDate = item.StockDate,
                    Price = item.ProductId.Price

                });
            }
            return list;
        }

        public StockViewModel Product(Product item)
        {
            return new StockViewModel
            {
                ProductId = item.Id,
                ProductName = item.Name,
                BrandsId = item.BrandId.Id,
                BrandsName = item.BrandId.Name,
                CategoryId = item.CategoryId.Id,
                CateogryName = item.CategoryId.Name
            };
        }

        public List<StockViewModel> ProductById(int id)
        {
            var stockById = _stockService.ProductById(id);
            List<StockViewModel> list = new List<StockViewModel>();

            foreach (var item in stockById)
            {
                list.Add(new StockViewModel {


                    Id = item.Id,
                    BrandsId = item.ProductId.BrandId.Id,
                    BrandsName = item.ProductId.BrandId.Name,
                    CategoryId = item.ProductId.CategoryId.Id,
                    CateogryName = item.ProductId.CategoryId.Name,
                    Piece = item.Piece,
                    ProductId = item.ProductId.Id,
                    ProductName = item.ProductId.Name,
                    StockDate = item.StockDate,
                    Price = item.ProductId.Price

                });
            }
            return list;
        }

        public List<StockViewModel> Search(string text)
        {
            List<StockViewModel> list = new List<StockViewModel>();

            foreach (var item in _stockService.Search(text))
            {
                list.Add(new StockViewModel
                {
                    Id = item.Id,
                    BrandsId = item.ProductId.BrandId.Id,
                    BrandsName = item.ProductId.BrandId.Name,
                    CategoryId = item.ProductId.CategoryId.Id,
                    CateogryName = item.ProductId.CategoryId.Name,
                    Piece = item.Piece,
                    ProductId = item.ProductId.Id,
                    ProductName = item.ProductId.Name,
                    StockDate = item.StockDate,
                    Price = item.ProductId.Price

                });
            }
            return list;
        }

        public Stock TEntity(StockViewModel entity)
        {
            var product = _productService.GetById(entity.ProductId);

            return new Stock
            {

                Id = entity.Id,
                Piece = entity.Piece,
                StockDate = entity.StockDate,
                ProductId = product
            };
        }
    }
}
