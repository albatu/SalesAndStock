using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IProductService
    {
        Product Insert(Product entity);
        Product Update(Product entity);
        Product GetById(int id);
        List<Product> GetAll();
        List<Product> Search(string text);
        List<Product> GetByAllId(int id);
        void Delete(Product entity);
    }
}
