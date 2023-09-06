using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class Shipper
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Url { get; set; }
        public double? Price { get; set; }
        public string? TrakingNumber { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
