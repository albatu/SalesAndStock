using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class ContactMapping : ClassMap<Contact>
    {
        public ContactMapping()
        {
            Table(@"Contact");
            Id(x => x.Id).Column("Id");
            Map(p => p.AddressDetails).Column("AddressDetails");
            Map(p => p.PostCode).Column("PostCode");
            References(p => p.CityId).Column("CityId").Not.LazyLoad();
            References(p => p.DistrictId).Column("DistrictId").Not.LazyLoad();
            References(p => p.CustomerId).Column("CustomerId").Not.LazyLoad();
            Map(p => p.Phone).Column("Phone");
        }
    }
}
