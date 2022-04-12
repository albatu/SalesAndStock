using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class EmployeesRolesMapping : ClassMap<EmployeesRoles>
    {
        public EmployeesRolesMapping()
        {
            Table("EmployeesRoles");
            Id(p => p.Id).Column("Id");
            References(p => p.EmployeeId).Column("EmployeeId").Not.LazyLoad();
            References(p => p.RoleId).Column("RoleId").Not.LazyLoad();

        }
    }
}
