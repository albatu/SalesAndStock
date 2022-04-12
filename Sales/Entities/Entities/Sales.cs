using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Sales : IEntity
    {
        public virtual int Id { get; set; }
        //adet
        public virtual int Piece { get; set; }
        public virtual DateTime Deliverydate { get; set; }
        //işlem tarihi
        public virtual DateTime DateOfTransaction { get; set; }
        public virtual Customer CustomerId { get; set; }
        public virtual Product ProductId { get; set; }
        public virtual Tax TaxId { get; set; }



    }
}
