using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class City
    {
        public City()
        {
            Addresses = new HashSet<Address>();
            Districts = new HashSet<District>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Code { get; set; }
        public int? CountryId { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<District> Districts { get; set; }
    }
}
