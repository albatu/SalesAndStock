using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IEmployeeDetailsService
    {
        EmployeeDetails Insert(EmployeeDetails entity);
        EmployeeDetails Update(EmployeeDetails entity);
        EmployeeDetails GetById(int id);
        List<EmployeeDetails> GetAll();
        List<EmployeeDetails> GetByAllId(int id);
        void Delete(EmployeeDetails entity);
    }
}
