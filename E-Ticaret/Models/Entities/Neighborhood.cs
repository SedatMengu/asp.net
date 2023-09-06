using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class Neighborhood
    {
        public Neighborhood()
        {
            Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Code { get; set; }
        public int? DistrictId { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
