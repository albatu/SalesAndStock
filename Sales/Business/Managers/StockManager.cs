using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Entities;

namespace Business.Managers
{
    public class StockManager : IStockService
    {
        private IStockDal _stockDal;


        public StockManager(IStockDal stockDal)
        {
            _stockDal = stockDal;

        }

        public List<Stock> DateToDate(DateTime startDate, DateTime finishDate)
        {
            return _stockDal.GetList(p => p.StockDate >= startDate && p.StockDate <= finishDate);
        }

        public void Delete(Stock entity)
        {
            _stockDal.Delete(entity);
        }

        public List<Stock> GetAll()
        {
            return _stockDal.GetList();
        }

        public List<Stock> GetByAllId(int id)
        {
            return _stockDal.GetList(p => p.ProductId.Id == id);
        }

        public Stock GetById(int id)
        {
            return _stockDal.Get(p => p.Id == id);
        }

        public Stock Insert(Stock entity)
        {
            return _stockDal.Add(entity);
        }

        public List<Stock> Paging(int skip, int take)
        {
            return _stockDal.GetList().Skip(skip).Take(take).ToList();
        }

        public List<Stock> Search(string text)
        {
            if (text != null)
            {

                return _stockDal.GetList(p => p.ProductId.Name.ToLower().Contains(text.ToLower()));
            }
            else
            {
                return _stockDal.GetList();
            }

        }

        public Stock Update(Stock entity)
        {
            return _stockDal.Update(entity);
        }
    }
}
