using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IEmployeesRolesService
    {
        EmployeesRoles Insert(EmployeesRoles entity);
        EmployeesRoles Update(EmployeesRoles entity);
        EmployeesRoles GetById(int id);
        List<EmployeesRoles> GetAll();
        List<EmployeesRoles> GetByAllId(int id);
        void Delete(EmployeesRoles entity);
    }
}
