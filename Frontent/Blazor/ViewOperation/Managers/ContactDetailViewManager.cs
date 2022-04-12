using Blazor2.Models.Customer;
using Blazor2.ViewOperation.Interfaces;
using Business.Interfaces;
using Entities.Entities;

namespace Blazor2.ViewOperation.Managers
{
    public class ContactDetailViewManager : IContactDetailViewService
    {
        private IContactService _contactService;
        private ICityService _cityService;
        private ICustomerService _customerService;

        public ContactDetailViewManager(IContactService contactService, 
            ICityService cityService, 
            ICustomerService customerService)
        {
            _contactService = contactService;
            _cityService = cityService;
            _customerService = customerService;
        }

        public List<ContactViewModel> District(int id)
        {
            List<ContactViewModel> list = new List<ContactViewModel>();
            foreach (var item in _cityService.District(id))
            {
                list.Add(new ContactViewModel { 
                
                    DistrictId = item.Id,
                    DistrictName = item.Name
                });
            }
            return list;
        }

        public List<ContactViewModel> District()
        {
            List<ContactViewModel> list = new List<ContactViewModel>();
            var districtBy = _cityService.GetAll().Where(p=>p.DistrictId!=0); ;

            foreach (var item in districtBy)
            {
                list.Add(new ContactViewModel { 
                
                   DistrictId = item.Id,
                   DistrictName = item.Name

                });
            }
            return list;
        }

        public List<ContactViewModel> DistrictById(int id)
        {
            List<ContactViewModel> list = new List<ContactViewModel>();
            var districtBy = _cityService.GetById(id);
            list.Add(new ContactViewModel { 
            
                DistrictId = districtBy.DistrictId,
                DistrictName = districtBy.Name
            });
            return list;
        }

        public ContactViewModel GetByContact(int id)
        {
            var contact = _contactService.GetByContact(id);
            if (contact == null)
            {
                return new ContactViewModel();
            }
            else
            {
                return new ContactViewModel
                {
                    Id = contact.Id,
                    AddressDetails = contact.AddressDetails,
                    CityId = contact.CityId.Id,
                    CityName = contact.CityId.Name,
                    CustomerId = contact.CustomerId.Id,
                    FirstName = contact.CustomerId.FirstName,
                    LastName = contact.CustomerId.LastName,
                    DistrictId = contact.DistrictId.Id,
                    DistrictName = contact.DistrictId.Name,
                    FirstNameAndLastName = contact.CustomerId.FirstName + " " + contact.CustomerId.LastName,
                    Phone = contact.Phone,
                    PostCode = contact.PostCode

                };
            }
            
        }
        public ContactViewModel GetByCustomer(int id)
        {
            var customer = _customerService.GetById(id);

            return new ContactViewModel { 
            
                CustomerId = customer.Id,
                LastName = customer.LastName,
                FirstName = customer.FirstName,
                FirstNameAndLastName = customer.FirstName +" "+ customer.LastName
            };
        }

        public List<ContactViewModel> GetByCustomerList(int id)
        {
            var customers = _customerService.GetByAllId(id);
            List<ContactViewModel> list = new List<ContactViewModel>();

            foreach (var item in customers)
            {
                list.Add(new ContactViewModel { 
                
                    CustomerId = item.Id,
                    FirstName = item.FirstName,
                    LastName  = item.LastName,
                    FirstNameAndLastName = item.FirstName +" "+item.LastName
                });
            }
            return list;
        }

        public List<ContactViewModel> GetCities()
        {
            List<ContactViewModel> list = new List<ContactViewModel>();
            var cities = _cityService.OnlyCity();

            foreach (var item in cities)
            {
                list.Add(new ContactViewModel { 
                
                    CityId = item.Id,
                    CityName = item.Name
                });
            }

            return list;
        }

        public Contact TEntity(ContactViewModel entity)
        {
            var city = _cityService.GetById(entity.CityId);
            var district = _cityService.GetById(entity.DistrictId);
            var customer = _customerService.GetById(entity.CustomerId);

            return new Contact
            {
                Id = entity.Id,
                AddressDetails = entity.AddressDetails,
                CityId = city,
                DistrictId = district,
                CustomerId = customer,
                Phone = entity.Phone,
                PostCode = entity.PostCode
            };
        }
    }
}
