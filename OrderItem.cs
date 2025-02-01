﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeGrabCommonModels;
public class OrderItem
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public double UnitPrice { get; set; }

    public int OrderId { get; set; }
    public Order Order { get; set; } = null!;
    public int ProductId { get; set; }
}
