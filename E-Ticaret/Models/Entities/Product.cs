using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class Product
    {
        public Product()
        {
            LikesNavigation = new HashSet<Like>();
            OrderDetails = new HashSet<OrderDetail>();
            ProductColors = new HashSet<ProductColor>();
            ProductFiles = new HashSet<ProductFile>();
            ProductImages = new HashSet<ProductImage>();
            ProductSizes = new HashSet<ProductSize>();
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
        public double? Price { get; set; }
        public int BrandId { get; set; }
        public int? Discount { get; set; }

        public virtual Brand Brand { get; set; } = null!;
        public virtual ProductCat Cat { get; set; } = null!;
        public virtual ICollection<Like> LikesNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductColor> ProductColors { get; set; }
        public virtual ICollection<ProductFile> ProductFiles { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductSize> ProductSizes { get; set; }
    }
}
