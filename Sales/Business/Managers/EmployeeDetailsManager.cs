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
    public class EmployeeDetailsManager : IEmployeeDetailsService
    {
        private IEmployeeDetailsDal _employeeDetailsDal;

        public EmployeeDetailsManager(IEmployeeDetailsDal employeeDetailsDal)
        {
            _employeeDetailsDal = employeeDetailsDal;
        }

        public void Delete(EmployeeDetails entity)
        {
            _employeeDetailsDal.Delete(entity);
        }

        public List<EmployeeDetails> GetAll()
        {
            return _employeeDetailsDal.GetList();
        }

        public List<EmployeeDetails> GetByAllId(int id)
        {
            return _employeeDetailsDal.GetList(p => p.Id == id);
        }

        public EmployeeDetails GetById(int id)
        {
            return _employeeDetailsDal.Get(p => p.Id == id);
        }

        public EmployeeDetails Insert(EmployeeDetails entity)
        {
            return _employeeDetailsDal.Add(entity);
        }

        public EmployeeDetails Update(EmployeeDetails entity)
        {
            return _employeeDetailsDal.Update(entity);
        }
    }
}
