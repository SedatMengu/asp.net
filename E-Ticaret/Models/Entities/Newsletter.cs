using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class Newsletter
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool? IsConfirm { get; set; }
        public string? Gsm { get; set; }
    }
}
