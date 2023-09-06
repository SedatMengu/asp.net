using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class Blog
    {
        public Blog()
        {
            BlogFiles = new HashSet<BlogFile>();
            BlogImages = new HashSet<BlogImage>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Detail { get; set; }
        public bool? IsConfirm { get; set; }
        public string? Image { get; set; }
        public string? Extension { get; set; }
        public string? Headline { get; set; }
        public int? RowNumber { get; set; }
        public int CatId { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public int? EditorId { get; set; }
        public DateTime? Date { get; set; }
        public int? Views { get; set; }
        public int? Likes { get; set; }

        public virtual BlogCat Cat { get; set; } = null!;
        public virtual Editor? Editor { get; set; }
        public virtual ICollection<BlogFile> BlogFiles { get; set; }
        public virtual ICollection<BlogImage> BlogImages { get; set; }
    }
}
