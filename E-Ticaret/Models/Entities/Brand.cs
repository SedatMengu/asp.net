﻿using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class Brand
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Detail { get; set; }
        public bool? IsConfirm { get; set; }
        public string? Image { get; set; }
        public string? Extension { get; set; }
        public string? Headline { get; set; }
        public string? Url { get; set; }
        public int? RowNumber { get; set; }
        public DateTime? Date { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
