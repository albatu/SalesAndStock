using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class CustomerMapping : ClassMap<Customer>
    {
        public CustomerMapping()
        {
            Table(@"Customer");
            Id(x => x.Id).Column("Id");
            Map(p => p.FirstName).Column("FirstName");
            Map(p => p.LastName).Column("LastName");
           
        }
    }
}
