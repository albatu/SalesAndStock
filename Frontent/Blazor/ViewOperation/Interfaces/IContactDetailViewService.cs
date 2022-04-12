
using Blazor2.Models.Customer;
using Entities.Entities;

namespace Blazor2.ViewOperation.Interfaces
{
    public interface IContactDetailViewService
    {
        List<ContactViewModel> GetCities();
        List<ContactViewModel> District(int id);
        List<ContactViewModel> District();
        List<ContactViewModel> DistrictById(int id);
        List<ContactViewModel> GetByCustomerList(int id);
        ContactViewModel GetByCustomer(int id);
        Contact TEntity(ContactViewModel entity);
        ContactViewModel GetByContact(int id);

    }
}
