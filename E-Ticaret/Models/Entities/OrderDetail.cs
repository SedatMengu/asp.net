using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int ProductId { get; set; }
        public int? RowNumber { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }
        public int? Discount { get; set; }
        public double? Total { get; set; }
        public int? SizeId { get; set; }
        public int? ColorId { get; set; }

        public virtual ProductColor? Color { get; set; }
        public virtual Order? Order { get; set; }
        public virtual Product Product { get; set; } = null!;
        public virtual ProductSize? Size { get; set; }
    }
}
