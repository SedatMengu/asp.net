using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class District
    {
        public District()
        {
            Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Code { get; set; }
        public int CityId { get; set; }

        public virtual City City { get; set; } = null!;
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
