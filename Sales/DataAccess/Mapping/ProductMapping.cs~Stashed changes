using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class ProductMapping : ClassMap<Product>
    {
        public ProductMapping()
        {
            Table(@"Product");
            Id(x => x.Id).Column("Id");
            Map(p => p.Name).Column("Name");
            Map(p => p.Description).Column("Description");
            Map(p => p.ProductCode).Column("ProductCode");
            Map(p => p.Price).Column("Price");
            Map(p => p.WeightUnit).Column("WeightUnit");
            Map(p => p.Length).Column("Length");
            Map(p => p.Weight).Column("Weight");
            References(p => p.BrandId).Column("BrandId").Not.LazyLoad();
            References(p => p.CategoryId).Column("CategoryId").Not.LazyLoad();
            References(p => p.TaxId).Column("TaxId").Not.LazyLoad();
        }
    }
}
