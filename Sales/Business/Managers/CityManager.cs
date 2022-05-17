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
    public class CityManager : ICityService
    {
        private ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public void Delete(City entity)
        {
            _cityDal.Delete(entity);
        }

        public List<City> District(int id)
        {
            return _cityDal.GetList(p=>p.DistrictId==id);
        }
        public List<City> District()
        {
            return _cityDal.GetList(p => p.DistrictId !=0);
        }
        public List<City> GetAll()
        {
            return _cityDal.GetList();
        }

        public List<City> GetByAllId(int id)
        {
            return _cityDal.GetList(p => p.Id == id);
        }

        public City GetById(int id)
        {
            return _cityDal.Get(p => p.Id == id);
        }

        public City Insert(City entity)
        {
            return _cityDal.Add(entity);
        }

        public List<City> OnlyCity()
        {
            return _cityDal.GetList(p=>p.DistrictId==0);
        }

        public City Update(City entity)
        {
            return _cityDal.Update(entity);
        }
    }
}
