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
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByAllId(int id)
        {
            return _productDal.GetList(p => p.Id == id);
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.Id == id);
        }

        public Product Insert(Product entity)
        {
            return _productDal.Add(entity);
        }

        public List<Product> Search(string text)
        {
            return _productDal.GetList(p=>p.Name.ToLower().Contains(text.ToLower()));
        }

        public Product Update(Product entity)
        {
            return _productDal.Update(entity);
        }
    }
}
