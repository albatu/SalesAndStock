using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Helpers.NHibernate
{
    public abstract class NHibernateHelper : IDisposable
    {
        private static ISessionFactory _sessionFactory;//Entity framework'te ki context yapısına denk geliyor

        public virtual ISessionFactory SessionFactory
        {
            //Mevcut Session varsa aktif et yoksa oluşturs
            get { return _sessionFactory ?? (_sessionFactory = InitializeFactory()); }
        }

        protected abstract ISessionFactory InitializeFactory();//Kim hangi ORM'i(Orn: oracle, SQLServer MySQL vb.) gönderirse ona göre oluştur
        //protected abstract ISessionFactory InitializeFactory();

        public virtual ISession OpenSession()
        {//Kişi nasıl bir sessionfactory gönderecekse onu kullnarak bana bir session aç
            return SessionFactory.OpenSession();
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);//Connection'ı kapat

        }
    }
}
