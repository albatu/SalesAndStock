using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class SalesMapping : ClassMap<Sales>
    {
        public SalesMapping()
        {
            Table(@"Sales");
            Id(x => x.Id).Column("Id");
            Map(p => p.Piece).Column("Piece");
            Map(p => p.Deliverydate).Column("Deliverydate");
            Map(p => p.DateOfTransaction).Column("DateOfTransaction");
            References(p => p.CustomerId).Column("CustomerId").Not.LazyLoad();
            References(p => p.ProductId).Column("ProductId").Not.LazyLoad();
            References(p => p.TaxId).Column("TaxId").Not.LazyLoad();
        }
    }
}
