using Core.DataAccess.Interfaces;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Helpers.NHibernate;

namespace Core.DataAccess.NHibernateManager
{
    public class NHEntityRepositoryManager<TEntity> : IEntityRepositoryService<TEntity>
        where TEntity : class, IEntity, new()
    {
        private NHibernateHelper _helper;

        public NHEntityRepositoryManager(NHibernateHelper helper)
        {
            _helper = helper;
        }

        public TEntity Add(TEntity entity)
        {
            using (var session = _helper.OpenSession())
            {
                session.Save(entity);
                return entity;
            };
        }

        public void Delete(TEntity entity)
        {
            using (var session = _helper.OpenSession())
            {
                session.Delete(entity);
                session.Flush();
                session.Clear();

            };
        }

        public TEntity Get(Expression<Func<TEntity, bool>>? filter = null)
        {
            using (var session = _helper.OpenSession())
            {

                return session.Query<TEntity>().SingleOrDefault(filter);
            };
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var session = _helper.OpenSession())
            {
                return filter == null ?
                    session.Query<TEntity>().ToList() :
                    session.Query<TEntity>().Where(filter).ToList();
            };
        }

        public TEntity Update(TEntity entity)
        {
            using (var session = _helper.OpenSession())
            {
                session.Update(entity);
                session.Flush();
                session.Clear();
                return entity;
            };
        }
    }
}
