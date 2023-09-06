using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class BlogTag
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public bool? IsConfirm { get; set; }
        public int? RowNumber { get; set; }
        public int BlogId { get; set; }
    }
}
