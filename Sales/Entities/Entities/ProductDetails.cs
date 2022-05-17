using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ProductDetails : IEntity
    {
        public virtual int Id { get; set; }
        public virtual DateTime PurchaseDate { get; set; }
        public virtual Product ProductId { get; set; }
        public virtual decimal CostPrice { get; set; }
        public virtual decimal SalePrice { get; set; }
    }
}
