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
    public class TaxManager : ITaxService
    {
        private ITaxDal _taxDal;

        public TaxManager(ITaxDal taxDal)
        {
            _taxDal = taxDal;
        }

        public void Delete(Tax entity)
        {
            _taxDal.Delete(entity);
        }

        public List<Tax> GetAll()
        {
            return _taxDal.GetList();
        }

        public List<Tax> GetByAllId(int id)
        {
            return _taxDal.GetList(p => p.Id == id);
        }

        public Tax GetById(int id)
        {
            return _taxDal.Get(p => p.Id == id);
        }

        public Tax Insert(Tax entity)
        {
            return _taxDal.Add(entity);
        }

        public Tax Update(Tax entity)
        {
            return _taxDal.Update(entity);
        }
    }
}
