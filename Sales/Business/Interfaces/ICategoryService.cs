using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ICategoryService
    {
        Category Insert(Category entity);
        Category Update(Category entity);
        Category GetById(int id);
        List<Category> GetAll();
        List<Category> GetByAllId(int id);
        void Delete(Category entity);
        
    }
}
