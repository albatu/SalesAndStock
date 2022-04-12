using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IContactService
    {
        Contact Insert(Contact entity);
        Contact Update(Contact entity);
        Contact GetById(int id);
        List<Contact> GetAll();
        List<Contact> GetByAllId(int id);
        void Delete(Contact entity);
        Contact GetByContact(int id);
    }
}
