using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class Editor
    {
        public Editor()
        {
            Blogs = new HashSet<Blog>();
        }

        public int Id { get; set; }
        public string? Title { get; set; }
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
        public string? Url { get; set; }
        public string? Linkedin { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
