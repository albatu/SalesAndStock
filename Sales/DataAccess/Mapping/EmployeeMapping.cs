using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class EmployeeMapping : ClassMap<Employee>
    {
        public EmployeeMapping()
        {
            Table("Employee");
            Id(p => p.Id).Column("Id");
            Map(p => p.FirstName).Column("FirstName");
            Map(p => p.LastName).Column("LastName");
            Map(p => p.Email).Column("Email");
            Map(p => p.Password).Column("Password");

        }
    }
}
