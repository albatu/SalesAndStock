using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ISalesService
    {
        Sales Insert(Sales entity);
        Sales Update(Sales entity);
        Sales GetById(int id);
        List<Sales> GetAll();
        List<Sales> GetByAllId(int id);
        void Delete(Sales entity);
    }
}
