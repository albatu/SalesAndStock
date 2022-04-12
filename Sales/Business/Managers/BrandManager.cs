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
    public class BrandManager : IBrandService
    {
        private IBrandsDal _brandsDal;

        public BrandManager(IBrandsDal brandsDal)
        {
            _brandsDal = brandsDal;
        }

        public void Delete(Brands entity)
        {
            _brandsDal.Delete(entity);
        }

        public List<Brands> GetAll()
        {
            return _brandsDal.GetList();
        }

        public List<Brands> GetByAllId(int id)
        {
            return _brandsDal.GetList(p => p.Id == id);
        }

        public Brands GetById(int id)
        {
            return _brandsDal.Get(p => p.Id == id);
        }

        public Brands Insert(Brands entity)
        {
            return _brandsDal.Add(entity);
        }

        public Brands Update(Brands entity)
        {
            return _brandsDal.Update(entity);
        }
    }
}
