using Blazor2.Models.Sales;
using Blazor2.ViewOperation.Interfaces;
using Business.Interfaces;
using Entities.Entities;

namespace Blazor2.ViewOperation.Managers
{
    public class SalesViewManager : ISalesViewService
    {
        private ISalesService _salesService;
        private IProductService _productService;
        private ITaxService _taxtService;
        private ICustomerService _customerService;
        public SalesViewManager(ISalesService salesService,
            IProductService productService, ICustomerService customerService,
            ITaxService taxtService)
        {
            _salesService = salesService;
            _productService = productService;
            _taxtService = taxtService;
            _customerService = customerService;
        }

        public List<SalesViewModel> CustomerList()
        {
            List<SalesViewModel> customerList = new List<SalesViewModel>();

            foreach (var item in _customerService.GetAll())
            {
                customerList.Add(new SalesViewModel
                {
                    CustomerId = item.Id,
                    CustomerFirstAndLastName = item.FirstName + " " + item.LastName
                });
            }
            return customerList;
        }

        public List<SalesViewModel> GetByDateList(DateTime startDate, DateTime finishDate)
        {
            List<SalesViewModel> list = new List<SalesViewModel>();

            foreach (var item in _salesService.GetAll().Where(p => p.Deliverydate >= startDate && p.Deliverydate <= finishDate).OrderByDescending(p => p.Id))
            {
                list.Add(new SalesViewModel
                {
                    Id = item.Id,
                    CustomerId = item.CustomerId.Id,
                    CustomerName = item.CustomerId.FirstName + " " + item.CustomerId.LastName,
                    DateOfTransction = item.DateOfTransaction,
                    TaxtId = item.TaxId.Id,
                    TaxType = item.TaxId.TaxType,
                    Percentile = item.TaxId.Percentile,
                    Deliverydate = item.Deliverydate,
                    Piece = item.Piece,
                    ProductId = item.ProductId.Id,
                    ProductName = item.ProductId.Name,

                });
            }
            return list;
        }

        public List<SalesViewModel> GetCustomerByIdList(int id)
        {
            List<SalesViewModel> list = new List<SalesViewModel>();
            var customerSales = _salesService.GetAll().Where(p => p.CustomerId.Id == id).OrderByDescending(p => p.Id);
            foreach (var item in customerSales)
            {
                list.Add(new SalesViewModel
                {
                    Id = item.Id,
                    CustomerId = item.CustomerId.Id,
                    CustomerName = item.CustomerId.FirstName + " " + item.CustomerId.LastName,
                    DateOfTransction = item.DateOfTransaction,
                    TaxtId = item.ProductId.TaxId.Id,
                    TaxType = item.ProductId.TaxId.TaxType,
                    Percentile = item.ProductId.TaxId.Percentile,
                    Deliverydate = item.Deliverydate,
                    Piece = item.Piece,
                    ProductId = item.ProductId.Id,
                    ProductName = item.ProductId.Name,

                });
            }
            return list;
        }

        public List<SalesViewModel> GetProductByIdList(int id)
        {
            List<SalesViewModel> list = new List<SalesViewModel>();

            foreach (var item in _salesService.GetAll().Where(p => p.ProductId.Id == id).OrderByDescending(p => p.Id))
            {
                list.Add(new SalesViewModel
                {
                    Id = item.Id,
                    CustomerId = item.CustomerId.Id,
                    CustomerName = item.CustomerId.FirstName + " " + item.CustomerId.LastName,
                    DateOfTransction = item.DateOfTransaction,
                    TaxtId = item.TaxId.Id,
                    TaxType = item.TaxId.TaxType,
                    Percentile = item.TaxId.Percentile,
                    Deliverydate = item.Deliverydate,
                    Piece = item.Piece,
                    ProductId = item.ProductId.Id,
                    ProductName = item.ProductId.Name,

                });
            }
            return list;
        }

        public List<SalesViewModel> GetProductList()
        {
            List<SalesViewModel> productList = new List<SalesViewModel>();

            foreach (var item in _productService.GetAll())
            {
                productList.Add(new SalesViewModel
                {
                    ProductId = item.Id,
                    ProductName = item.Name,
                    Price = item.Price
                });
            }
            return productList;
        }

        public List<SalesViewModel> GetSalesList()
        {
            List<SalesViewModel> list = new List<SalesViewModel>();

            foreach (var item in _salesService.GetAll().OrderByDescending(p => p.Id))
            {
                list.Add(new SalesViewModel
                {
                    Id = item.Id,
                    CustomerId = item.CustomerId.Id,
                    CustomerName = item.CustomerId.FirstName + " " + item.CustomerId.LastName,
                    DateOfTransction = item.DateOfTransaction,
                    TaxtId = item.ProductId.TaxId.Id,
                    TaxType = item.ProductId.TaxId.TaxType,
                    Percentile = item.ProductId.TaxId.Percentile,
                    Deliverydate = item.Deliverydate,
                    Piece = item.Piece,
                    ProductId = item.ProductId.Id,
                    ProductName = item.ProductId.Name,
                    Price = item.ProductId.Price

                });
            }
            return list;
        }

        public Sales TEntity(SalesViewModel entity)
        {
            var product = _productService.GetById(entity.ProductId);
            var tax = _taxtService.GetById(entity.TaxtId);
            var customer = _customerService.GetById(entity.CustomerId);
            return new Sales
            {

                Id = entity.Id,
                Piece = entity.Piece,
                CustomerId = customer,
                TaxId = tax,
                ProductId = product,
                DateOfTransaction = entity.DateOfTransction,
                Deliverydate = entity.Deliverydate
            };
        }
    }
}
