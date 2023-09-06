using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class BlogFile
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Detail { get; set; }
        public bool? IsConfirm { get; set; }
        public string? Extension { get; set; }
        public string? Headline { get; set; }
        public int? RowNumber { get; set; }
        public int TypeId { get; set; }
        public int? Size { get; set; }
        public string? Name { get; set; }

        public virtual Blog Type { get; set; } = null!;
    }
}
