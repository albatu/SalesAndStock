using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class RoleMapping : ClassMap<Role>
    {
        public RoleMapping()
        {
            Table(@"Role");
            Id(x => x.Id).Column("Id");
            Map(p => p.Name).Column("Name");
           
        }
    }
}
