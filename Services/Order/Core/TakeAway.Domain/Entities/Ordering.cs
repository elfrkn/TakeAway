﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeAway.Domain.Entities
{
    public class Ordering
    {
        public  int OrderingId { get; set; }
        public  string UserId { get; set; }
        public  decimal TotalDecimal { get; set; }
        public  DateTime OrderDate { get; set; }
        public  List<OrderDetail> OrderDetails { get; set; }
    }
}
