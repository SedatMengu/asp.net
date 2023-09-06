using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class Comment
    {
        public int Id { get; set; }
        public bool? IsConfirm { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Subject { get; set; }
        public string Comment1 { get; set; } = null!;
        public DateTime? Date { get; set; }
        public string Type { get; set; } = null!;
        public int TypeId { get; set; }
        public int? Rate { get; set; }
        public bool? IsRead { get; set; }
    }
}
