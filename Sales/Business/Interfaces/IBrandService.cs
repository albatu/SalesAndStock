using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IBrandService
    {
        Brands Insert(Brands entity);
        Brands Update(Brands entity);
        Brands GetById(int id);
        List<Brands> GetAll();
        List<Brands> GetByAllId(int id);
        void Delete(Brands entity);
    }
}
