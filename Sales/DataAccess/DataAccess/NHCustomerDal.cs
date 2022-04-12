using Core.DataAccess.NHibernateManager;
using DataAccess.Helpers;
using DataAccess.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccess
{
    public class NHCustomerDal : NHEntityRepositoryManager<Customer>, ICustomerDal
    {
        public NHCustomerDal(SQLDbHelper helper) : base(helper)
        {

        }
    }
}
