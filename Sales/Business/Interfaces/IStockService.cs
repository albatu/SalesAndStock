using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IStockService
    {
        Stock Insert(Stock entity);
        Stock Update(Stock entity);
        Stock GetById(int id);
        List<Stock> GetAll();
        List<Stock> GetByAllId(int id);
        List<Stock> Search(string text);
        List<Stock> DateToDate(DateTime startDate, DateTime finishDate);
        void Delete(Stock entity);
        List<Stock> Paging(int skip, int take);
        List<Stock> ProductById(int id);
    }
}
