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
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void Delete(Employee entity)
        {
            _employeeDal.Delete(entity);
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetList();
        }

        public List<Employee> GetByAllId(int id)
        {
            return _employeeDal.GetList(p => p.Id == id);
        }

        public Employee GetById(int id)
        {
            return _employeeDal.Get(p => p.Id == id);
        }

        public Employee Insert(Employee entity)
        {
            return _employeeDal.Add(entity);
        }

        public Employee Update(Employee entity)
        {
            return _employeeDal.Update(entity);
        }
    }
}
