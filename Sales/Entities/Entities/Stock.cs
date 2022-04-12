using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Stock : IEntity
    {
        public virtual int Id { get; set; }
        public virtual Product ProductId { get; set; }
        public virtual int Piece { get; set; }
        public virtual DateTime StockDate { get; set; }

    }
}
