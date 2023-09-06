using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class Country
    {
        public Country()
        {
            Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string Language { get; set; } = null!;
        public int? PhoneCode { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
