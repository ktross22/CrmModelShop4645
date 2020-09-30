﻿

using System.Collections;
using System.Collections.Generic;
using CrmBL.Model;

namespace CrmBL
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }


        public override string ToString()
        {
            return Name;
        }
    }
}
