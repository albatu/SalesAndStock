using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class EmployeeDetails : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Address { get; set; }
        public virtual City CityId { get; set; }
        public virtual City DistrictId { get; set; }

    }
}
