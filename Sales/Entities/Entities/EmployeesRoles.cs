using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class EmployeesRoles : IEntity
    {
        public virtual int Id { get; set; }
        public virtual Employee EmployeeId { get; set; }
        public virtual Role RoleId { get; set; }
    }
}
