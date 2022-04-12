using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ICustomerService
    {
        Customer Insert(Customer entity);
        Customer Update(Customer entity);
        Customer GetById(int id);
        List<Customer> GetAll();
        List<Customer> GetByAllId(int id);
        void Delete(Customer entity);
    }
}
