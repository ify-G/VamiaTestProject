﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vamia.Domain.Entities
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }

        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}
