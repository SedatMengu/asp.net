using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class Address
    {
        public Address()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? DistrictId { get; set; }
        public string? Adress { get; set; }
        public string? Name { get; set; }
        public int? NeighborhoodId { get; set; }
        public int? StreetId { get; set; }

        public virtual City? City { get; set; }
        public virtual Country? Country { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual District? District { get; set; }
        public virtual Neighborhood? Neighborhood { get; set; }
        public virtual Street? Street { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
