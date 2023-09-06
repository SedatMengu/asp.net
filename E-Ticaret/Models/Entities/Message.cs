using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class Message
    {
        public int? Id { get; set; }
        public string? Message1 { get; set; }
        public DateTime? Date { get; set; }
        public int? SenderId { get; set; }
        public bool? IsRead { get; set; }
        public int? RecipientId { get; set; }
        public bool? IsLike { get; set; }
    }
}
