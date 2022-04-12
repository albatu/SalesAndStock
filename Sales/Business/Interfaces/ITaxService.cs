using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ITaxService
    {
        Tax Insert(Tax entity);
        Tax Update(Tax entity);
        Tax GetById(int id);
        List<Tax> GetAll();
        List<Tax> GetByAllId(int id);
        void Delete(Tax entity);
    }
}
