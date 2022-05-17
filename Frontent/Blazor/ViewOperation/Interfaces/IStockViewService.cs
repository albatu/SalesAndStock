using Blazor2.Models.Stock;
using Entities.Entities;

namespace Blazor2.ViewOperation.Interfaces
{
    public interface IStockViewService
    {
        Stock TEntity(StockViewModel entity);
        List<StockViewModel> GetStockList();
        List<StockViewModel> Search(string text);
        List<StockViewModel> GetProductList();
        List<StockViewModel> DateToDate(DateTime startDate, DateTime finishDate);
        List<StockViewModel> Paging(int skip, int take);
        StockViewModel GetById(int id);
        StockViewModel NewStock();
        StockViewModel Product(Product entity);
        List<StockViewModel> ProductById(int id);
    }
}
