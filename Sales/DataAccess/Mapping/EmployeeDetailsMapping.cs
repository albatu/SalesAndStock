using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class EmployeeDetailsMapping : ClassMap<EmployeeDetails>
    {
        public EmployeeDetailsMapping()
        {
            Table(@"EmployeeDetails");
            Id(x => x.Id).Column("Id");
            Map(p => p.Phone).Column("Phone");
            Map(p => p.Address).Column("PostCode");
            References(p => p.CityId).Column("CityId").Not.LazyLoad();
            References(p => p.DistrictId).Column("DistrictId").Not.LazyLoad();
            
        }
    }
}
