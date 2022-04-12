using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class BillMapping : ClassMap<Bill>
    {
        public BillMapping()
        {
            Table(@"Bill");
            Id(x => x.Id).Column("Id");
            Map(p => p.BillNo).Column("BillNo");
            References(p => p.SalesId).Column("SalesId").Not.LazyLoad();
        }
    }
}
