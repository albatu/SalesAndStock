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
    public class RoleManager : IRoleService
    {
        private IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public void Delete(Role entity)
        {
            _roleDal.Delete(entity);
        }

        public List<Role> GetAll()
        {
            return _roleDal.GetList();
        }

        public List<Role> GetByAllId(int id)
        {
            return _roleDal.GetList(p => p.Id == id);
        }

        public Role GetById(int id)
        {
            return _roleDal.Get(p => p.Id == id);
        }

        public Role Insert(Role entity)
        {
            return _roleDal.Add(entity);
        }

        public Role Update(Role entity)
        {
            return _roleDal.Update(entity);
        }
    }
}
