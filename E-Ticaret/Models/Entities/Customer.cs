using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class Customer
    {
        public Customer()
        {
            Addresses = new HashSet<Address>();
            LikesNavigation = new HashSet<Like>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Detail { get; set; }
        public bool? IsConfirm { get; set; }
        public string? Image { get; set; }
        public string? Extension { get; set; }
        public string? Headline { get; set; }
        public int? RowNumber { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public DateTime? Date { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Linkedin { get; set; }
        public string? Facebook { get; set; }
        public string? Instagram { get; set; }
        public string? Twitter { get; set; }
        public string? Lastname { get; set; }
        public bool? IsEmailView { get; set; }
        public bool? IsLinkedinVİew { get; set; }
        public bool? IsFacebookView { get; set; }
        public bool? IsInstagramView { get; set; }
        public bool? IsTwitterView { get; set; }
        public int? Views { get; set; }
        public int? Likes { get; set; }
        public string? PasswordNew { get; set; }
        public string? PasswordNewConfirm { get; set; }
        public bool? Gender { get; set; }
        public string? Phone { get; set; }
        public string? Code { get; set; }
        public bool? IsAgreement { get; set; }
        public bool? IsRemember { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Like> LikesNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
