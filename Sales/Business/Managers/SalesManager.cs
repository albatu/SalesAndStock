using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Entities;

namespace Business.Managers
{
    public class SalesManager : ISalesService
    {
        private ISalesDal _salesDal;

        public SalesManager(ISalesDal salesDal)
        {
            _salesDal = salesDal;
        }

        public void Delete(Sales entity)
        {
             _salesDal.Delete(entity);
        }

        public List<Sales> GetAll()
        {
            return _salesDal.GetList();
        }

        public List<Sales> GetByAllId(int id)
        {
            return _salesDal.GetList(p => p.Id == id);
        }

        public Sales GetById(int id)
        {
            return _salesDal.Get(p => p.Id == id);
        }

        public Sales Insert(Sales entity)
        {
            return _salesDal.Add(entity);
        }

        public Sales Update(Sales entity)
        {
            return _salesDal.Update(entity);
        }
    }
}
