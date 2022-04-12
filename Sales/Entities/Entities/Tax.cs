﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Tax : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string TaxType { get; set; }
        //yüzde
        public virtual int Percentile { get; set; }

    }
}
