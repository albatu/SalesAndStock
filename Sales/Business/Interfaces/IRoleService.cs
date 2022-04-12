using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IRoleService
    {
        Role Insert(Role entity);
        Role Update(Role entity);
        Role GetById(int id);
        List<Role> GetAll();
        List<Role> GetByAllId(int id);
        void Delete(Role entity);
    }
}
