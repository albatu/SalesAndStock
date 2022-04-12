using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Business.Managers
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Delete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public List<Category> GetByAllId(int id)
        {
            return _categoryDal.GetList(p=>p.Id == id);
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(p => p.Id == id);
        }

        public Category Insert(Category entity)
        {
            return _categoryDal.Add(entity);
        }

        public Category Update(Category entity)
        {
            return _categoryDal.Update(entity);
        }
    }
}
