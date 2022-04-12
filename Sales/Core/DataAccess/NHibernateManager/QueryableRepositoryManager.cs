using Core.DataAccess.Helpers.NHibernate;
using Core.DataAccess.Interfaces;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albatu.Core.DataAccess.NHibernateManager
{
    public class QueryableRepositoryManager<T> : IQueryableRepositoryService<T> where T : class, IEntity, new()
    {
        NHibernateHelper _helper;
        IQueryable<T> _entities;
        public QueryableRepositoryManager(NHibernateHelper helper)
        {
            _helper = helper;
        }
        public IQueryable<T> Tables => this.Entities;

        public virtual IQueryable<T> Entities
        {

            get { return _entities ?? (_entities = _helper.OpenSession().Query<T>()); }

        }
    }
}
