using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ICityService
    {
        City Insert(City entity);
        City Update(City entity);
        City GetById(int id);
        List<City> GetAll();
        List<City> GetByAllId(int id);
        void Delete(City entity);
        List<City> District(int id);
        List<City> OnlyCity();
    }
}
