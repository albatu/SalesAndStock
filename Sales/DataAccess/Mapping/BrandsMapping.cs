using Entities.Entities;
using FluentNHibernate.Mapping;
using FluentNHibernate.MappingModel.ClassBased;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class BrandsMapping : ClassMap<Brands>
    {
        public BrandsMapping()
        {
            Table("Brands");
            Id(p => p.Id).Column("Id");
            Map(p => p.Name).Column("Name");
            Map(p => p.Phone).Column("Phone");
            Map(p => p.CompanyRepresentative).Column("CompanyRepresentative");
        }
    }
}
