﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Models
{
    public class Orders
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public List<Items> Items { get; set; }
    }
}
