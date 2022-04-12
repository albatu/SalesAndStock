using Core.DataAccess.Helpers.NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.Extensions.Configuration;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Helpers
{
    public class SQLDbHelper : Core.DataAccess.Helpers.NHibernate.NHibernateHelper
    {

        private readonly IConfiguration _configuration;

        public SQLDbHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override ISessionFactory InitializeFactory()
        {
            var connection = _configuration.GetConnectionString("MySQLConnection");
            return Fluently
                .Configure()
                    .Database(
                        MySQLConfiguration.Standard
                        .ConnectionString(connection))
                     .Mappings(t => t.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                    .ExposeConfiguration(TreatConfiguration)
                .BuildSessionFactory();
        }

        private static void TreatConfiguration(Configuration configuration)
        {
            var update = new SchemaUpdate(configuration);
            update.Execute(false, true);
        }
    }
}
