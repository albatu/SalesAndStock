using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IBillService
    {
        Bill Insert(Bill entity);
        Bill Update(Bill entity);
        Bill GetById(int id);
        List<Bill> GetAll();
        List<Bill> GetByAllId(int id);
        void Delete(Bill entity);
    }
}
