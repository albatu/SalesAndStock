using Blazor2.Models.Sales;
using Entities.Entities;

namespace Blazor2.ViewOperation.Interfaces
{
    public interface ISalesViewService
    {
        Sales TEntity(SalesViewModel entity);
        List<SalesViewModel> GetSalesList();
        List<SalesViewModel> CustomerList();
        List<SalesViewModel> GetProductByIdList(int id);
        List<SalesViewModel> GetCustomerByIdList(int id);
        List<SalesViewModel> GetByDateList(DateTime startDate,DateTime finishDate);
        List<SalesViewModel> GetProductList();
    }
}
