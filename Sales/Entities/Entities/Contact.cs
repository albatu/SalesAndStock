using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Contact : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string AddressDetails { get; set; }
        public virtual string PostCode { get; set; }
        public virtual City CityId { get; set; }
        public virtual City DistrictId { get; set; }
        public virtual Customer CustomerId { get; set; }
        public virtual string Phone { get; set; }


    }
}
