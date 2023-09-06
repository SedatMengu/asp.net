using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class Banner
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Detail { get; set; }
        public bool? IsConfirm { get; set; }
        public string? Image { get; set; }
        public string? Extension { get; set; }
        public string? Headline { get; set; }
        public byte[]? Url { get; set; }
        public int? RowNumber { get; set; }
        public string? Target { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
    }
}
