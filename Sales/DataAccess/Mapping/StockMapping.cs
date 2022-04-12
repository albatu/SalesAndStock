using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class StockMapping : ClassMap<Stock>
    {
        public StockMapping()
        {
            Table(@"Stock");
            Id(x => x.Id).Column("Id");
            Map(p => p.Piece).Column("Piece");
            Map(p => p.StockDate).Column("StockDate");
            References(p => p.ProductId).Column("ProductId").Not.LazyLoad();
        }
    }
}
