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
    public class ContactManager : IContactService
    {
        private IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;


        }

        public void Delete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public List<Contact> GetAll()
        {
            return _contactDal.GetList();
        }

        public List<Contact> GetByAllId(int id)
        {
            return _contactDal.GetList(p => p.Id == id);
        }

        public Contact GetByContact(int id)
        {
            return _contactDal.Get(p => p.CustomerId.Id == id);
        }

        public Contact GetById(int id)
        {
            return _contactDal.Get(p => p.Id == id);
        }

        public Contact Insert(Contact entity)
        {
            return _contactDal.Add(entity);
        }

        public Contact Update(Contact entity)
        {
            return _contactDal.Update(entity);
        }
    }
}
