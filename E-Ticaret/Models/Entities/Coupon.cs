using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class Coupon
    {
        public int Id { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Code { get; set; }
        public string? IsConfirm { get; set; }
        public string? Type { get; set; }
        public int? CustomerId { get; set; }
        public int? Amount { get; set; }
    }
}
