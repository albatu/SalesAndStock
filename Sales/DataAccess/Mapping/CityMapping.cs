using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class CityMapping : ClassMap<City>
    {
        public CityMapping()
        {
            Table("City");
            Id(p => p.Id).Column("Id");
            Map(p => p.Name).Column("Name");
            Map(p => p.DistrictId).Column("DistrictId");

        }
    }
}
