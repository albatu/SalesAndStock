using Business.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Interfaces;
namespace Business.Managers
{
    public class BillManager : IBillService
    {
        private IBillDal _billDal;

        public BillManager(IBillDal billDal)
        {
            _billDal = billDal;
        }

        public void Delete(Bill entity)
        {
            _billDal.Delete(entity);
        }

        public List<Bill> GetAll()
        {
            return _billDal.GetList();
        }

        public List<Bill> GetByAllId(int id)
        {
            return _billDal.GetList(p => p.Id == id);
        }

        public Bill GetById(int id)
        {
            return _billDal.Get(p => p.Id == id);
        }

        public Bill Insert(Bill entity)
        {
            return _billDal.Add(entity);
        }

        public Bill Update(Bill entity)
        {
            return _billDal.Update(entity);
        }
    }
}
