using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? PaymentId { get; set; }
        public int? ShipperId { get; set; }
        public DateTime? OrderDate { get; set; }
        public bool? IsPaid { get; set; }
        public bool? IsComplated { get; set; }
        public int? AdressId { get; set; }

        public virtual Address? Adress { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual Payment? Payment { get; set; }
        public virtual Shipper? Shipper { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
