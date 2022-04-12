using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IEmployeeService
    {
        Employee Insert(Employee entity);
        Employee Update(Employee entity);
        Employee GetById(int id);
        List<Employee> GetAll();
        List<Employee> GetByAllId(int id);
        void Delete(Employee entity);
    }
}
