using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class CategoryMapping : ClassMap<Category>
    {
        public CategoryMapping()
        {
            Table("Category");
            Id(p => p.Id).Column("Id");
            Map(p => p.Name).Column("Name");
            Map(p => p.Description).Column("Description").CustomSqlType("text");

        }
    }
}
