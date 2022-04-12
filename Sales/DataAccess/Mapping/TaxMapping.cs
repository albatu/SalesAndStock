using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class TaxMapping : ClassMap<Tax>
    {
        public TaxMapping()
        {
            Table(@"Tax");
            Id(x => x.Id).Column("Id");
            Map(p => p.TaxType).Column("TaxType");
            Map(p => p.Percentile).Column("Percentile");

        }
    }
}
