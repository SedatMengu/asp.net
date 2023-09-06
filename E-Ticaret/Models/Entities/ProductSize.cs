using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class ProductSize
    {
        public ProductSize()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string Size { get; set; } = null!;
        public bool? IsConfirm { get; set; }
        public int? RowNumber { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
