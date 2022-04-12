using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Bill : IEntity
    {
        public virtual int Id { get; set; }
        public virtual Sales SalesId { get; set; }
        public virtual string BillNo { get; set; }

    }
}
