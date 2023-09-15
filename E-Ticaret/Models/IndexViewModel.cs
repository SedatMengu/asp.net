using asp.net2;

namespace ETicaret.Models
{
    public class IndexViewModel
    {
        public required Address Address { get; set; }
        public required IEnumerable<Address> Addresses { get; set; }
        public required Band Band { get; set; }
        public required IEnumerable<Band> Bands { get; set; }
        public required Banner Banner { get; set; }
        public required IEnumerable<Banner> Banners { get; set; }
        public required Blog Blog { get; set; }
        public required IEnumerable<Blog> Blogs { get; set; }
        public required BlogCat BlogCat { get; set; }
        public required IEnumerable<BlogCat> BlogCats { get; set; }
        public required BlogFile BlogFile { get; set; }
        public required IEnumerable<BlogFile> BlogFiles { get; set; }
        public required BlogImage BlogImage { get; set; }
        public required IEnumerable<BlogImage> BlogImages { get; set; }
        public required BlogTag BlogTag { get; set; }
        public required IEnumerable<BlogTag> BlogTags { get; set; }
        public required Brand Brand { get; set; }
        public required IEnumerable<Brand> Brands { get; set; }
        public required City City { get; set; }
        public required IEnumerable<City> Cities { get; set; }
        public required Comment Comment { get; set; }
        public required IEnumerable<Comment> Comments { get; set; }
        public required ContactForm ContactForm { get; set; }
        public required IEnumerable<ContactForm> ContactForms { get; set; }
        public required Country Country { get; set; }
        public required IEnumerable<Country> Countries { get; set; }
        public required Coupon Coupon { get; set; }
        public required IEnumerable<Coupon> Coupons { get; set; }
        public required Customer Customer { get; set; }
        public required IEnumerable<Customer> Customers { get; set; }
        public required District District { get; set; }
        public required IEnumerable<District> Districts { get; set; }
        public required Editor Editor { get; set; }
        public required IEnumerable<Editor> Editors { get; set; }
        public required ETicaretDBContext ETicaretDBContext { get; set; }
        public required IEnumerable<ETicaretDBContext> ETicaretDBContexts { get; set; }
        public required Like Like { get; set; }
        public required IEnumerable<Like> Likes { get; set; }
        public required Message Message { get; set; }
        public required IEnumerable<Message> Messages { get; set; }
        public required Neighborhood Neighborhood { get; set; }
        public required IEnumerable<Neighborhood> Neighborhoods { get; set; }
        public required Newsletter Newsletter { get; set; }
        public required IEnumerable<Newsletter> Newsletters { get; set; }
        public required Order Order { get; set; }
        public required IEnumerable<Order> Orders { get; set; }
        public required OrderDetail OrderDetail { get; set; }
        public required IEnumerable<OrderDetail> OrderDetails { get; set; }
        public required Payment Payment { get; set; }
        public required IEnumerable<Payment> Payments { get; set; }
        public required Product Product { get; set; }
        public required IEnumerable<Product> Products { get; set; }
        public required ProductCat ProductCat { get; set; }
        public required IEnumerable<ProductCat> ProductCats { get; set; }
        public required ProductColor ProductColor { get; set; }
        public required IEnumerable<ProductColor> ProductColors { get; set; }
        public required ProductFile ProductFile { get; set; }
        public required IEnumerable<ProductFile> ProductFiles { get; set; }
        public required ProductImage ProductImage { get; set; }
        public required IEnumerable<ProductImage> ProductImages { get; set; }
        public required ProductSize ProductSize { get; set; }
        public required IEnumerable<ProductSize> ProductSizes { get; set; }
        public required Shipper Shipper { get; set; }
        public required IEnumerable<Shipper> Shippers { get; set; }
        public required Site Site { get; set; }
        public required IEnumerable<Site> Sites { get; set; }
        public required Slide Slide { get; set; }
        public required IEnumerable<Slide> Slides { get; set; }
        public required Street Street { get; set; }
        public required IEnumerable<Street> Streets { get; set; }
    }
}