using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Entities.Entities;
using DataAccess.Interfaces;
namespace Business.Managers
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Delete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetList().OrderByDescending(p=>p.Id).ToList();
        }

        public List<Customer> GetByAllId(int id)
        {
            return _customerDal.GetList(p => p.Id == id);
        }

        public Customer GetById(int id)
        {
            return _customerDal.Get(p => p.Id == id);
        }

        public Customer Insert(Customer entity)
        {
            return _customerDal.Add(entity);
        }

        public Customer Update(Customer entity)
        {
            return _customerDal.Update(entity);
        }
    }
}
