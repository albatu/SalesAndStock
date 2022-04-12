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
    public class EmployeesRolesManager : IEmployeesRolesService
    {
        private IEmployeesRolesDal _employeesRolesDal;

        public EmployeesRolesManager(IEmployeesRolesDal employeesRolesDal)
        {
            _employeesRolesDal = employeesRolesDal;
        }

        public void Delete(EmployeesRoles entity)
        {
            _employeesRolesDal.Delete(entity);
        }

        public List<EmployeesRoles> GetAll()
        {
            return _employeesRolesDal.GetList();
        }

        public List<EmployeesRoles> GetByAllId(int id)
        {
            return _employeesRolesDal.GetList(p=>p.Id == id);
        }

        public EmployeesRoles GetById(int id)
        {
            return _employeesRolesDal.Get(p => p.Id == id);
        }

        public EmployeesRoles Insert(EmployeesRoles entity)
        {
            return _employeesRolesDal.Add(entity);
        }

        public EmployeesRoles Update(EmployeesRoles entity)
        {
            return _employeesRolesDal.Update(entity);
        }
    }
}
