using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class Payment
    {
        public Payment()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public bool? IsAllow { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
