using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class ContactForm
    {
        public int Id { get; set; }
        public bool? IsConfirm { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public DateTime? Date { get; set; }
    }
}
