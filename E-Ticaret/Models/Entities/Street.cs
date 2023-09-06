using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class Street
    {
        public Street()
        {
            Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int NeighborhoodId { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
