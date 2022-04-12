using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Product : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string ProductCode { get; set; }
        public virtual decimal Price { get; set; }
        public virtual Brands BrandId { get; set; }
        public virtual Category CategoryId { get; set; }
        public virtual int Weight { get; set; }
        public virtual int Length { get; set; }
        public virtual bool WeightUnit { get; set; }
        public virtual Tax TaxId { get; set; }
    }
}
