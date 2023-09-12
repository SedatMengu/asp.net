using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace asp.net2
{
    public partial class ETicaretDBContext : DbContext
    {
        public ETicaretDBContext()
        {
        }

        public ETicaretDBContext(DbContextOptions<ETicaretDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<Band> Bands { get; set; } = null!;
        public virtual DbSet<Banner> Banners { get; set; } = null!;
        public virtual DbSet<Blog> Blogs { get; set; } = null!;
        public virtual DbSet<BlogCat> BlogCats { get; set; } = null!;
        public virtual DbSet<BlogFile> BlogFiles { get; set; } = null!;
        public virtual DbSet<BlogImage> BlogImages { get; set; } = null!;
        public virtual DbSet<BlogTag> BlogTags { get; set; } = null!;
        public virtual DbSet<Brand> Brands { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<ContactForm> ContactForms { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Coupon> Coupons { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<District> Districts { get; set; } = null!;
        public virtual DbSet<Editor> Editors { get; set; } = null!;
        public virtual DbSet<Like> Likes { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;
        public virtual DbSet<Neighborhood> Neighborhoods { get; set; } = null!;
        public virtual DbSet<Newsletter> Newsletters { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductCat> ProductCats { get; set; } = null!;
        public virtual DbSet<ProductColor> ProductColors { get; set; } = null!;
        public virtual DbSet<ProductFile> ProductFiles { get; set; } = null!;
        public virtual DbSet<ProductImage> ProductImages { get; set; } = null!;
        public virtual DbSet<ProductSize> ProductSizes { get; set; } = null!;
        public virtual DbSet<Shipper> Shippers { get; set; } = null!;
        public virtual DbSet<Site> Sites { get; set; } = null!;
        public virtual DbSet<Slide> Slides { get; set; } = null!;
        public virtual DbSet<Street> Streets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("server=localhost; user=sa; password=reallyStrongPwd123; database=ETicaretDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Turkish_CI_AS");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Adress).HasColumnType("text");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NeighborhoodId).HasColumnName("NeighborhoodID");

                entity.Property(e => e.StreetId).HasColumnName("StreetID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Address_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Address_Country");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Address_Customer");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_Address_District");

                entity.HasOne(d => d.Neighborhood)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.NeighborhoodId)
                    .HasConstraintName("FK_Address_Neighborhood");

                entity.HasOne(d => d.Street)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.StreetId)
                    .HasConstraintName("FK_Address_Street");
            });

            modelBuilder.Entity<Band>(entity =>
            {
                entity.ToTable("Band");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detail).HasColumnType("text");

                entity.Property(e => e.Extension).HasMaxLength(50);

                entity.Property(e => e.Headline).HasColumnType("text");

                entity.Property(e => e.Height).HasDefaultValueSql("((0))");

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.IsConfirm).HasDefaultValueSql("((0))");

                entity.Property(e => e.RowNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.Target).HasMaxLength(50);

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.Property(e => e.Width).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Banner>(entity =>
            {
                entity.ToTable("Banner");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detail).HasColumnType("text");

                entity.Property(e => e.Extension).HasMaxLength(50);

                entity.Property(e => e.Headline).HasColumnType("text");

                entity.Property(e => e.Height).HasDefaultValueSql("((0))");

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.IsConfirm).HasDefaultValueSql("((0))");

                entity.Property(e => e.Target).HasMaxLength(50);

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.Property(e => e.Width).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.ToTable("Blog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Detail).HasColumnType("text");

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.Extension).HasMaxLength(50);

                entity.Property(e => e.Headline).HasColumnType("text");

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.IsConfirm).HasDefaultValueSql("((0))");

                entity.Property(e => e.Likes).HasDefaultValueSql("((0))");

                entity.Property(e => e.RowNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.Views).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Blogs)
                    .HasForeignKey(d => d.CatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Blog_BlogCat");

                entity.HasOne(d => d.Editor)
                    .WithMany(p => p.Blogs)
                    .HasForeignKey(d => d.EditorId)
                    .HasConstraintName("FK_Blog_Editor");
            });

            modelBuilder.Entity<BlogCat>(entity =>
            {
                entity.ToTable("BlogCat");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.Detail).HasColumnType("text");

                entity.Property(e => e.Extension).HasMaxLength(50);

                entity.Property(e => e.Headline).HasColumnType("text");

                entity.Property(e => e.Height).HasDefaultValueSql("((0))");

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.IsConfirm).HasDefaultValueSql("((0))");

                entity.Property(e => e.RowNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.Width).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<BlogFile>(entity =>
            {
                entity.ToTable("BlogFile");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detail).HasColumnType("text");

                entity.Property(e => e.Extension).HasMaxLength(50);

                entity.Property(e => e.Headline).HasColumnType("text");

                entity.Property(e => e.IsConfirm).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.RowNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.Size).HasDefaultValueSql("((0))");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.BlogFiles)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogFile_Blog");
            });

            modelBuilder.Entity<BlogImage>(entity =>
            {
                entity.ToTable("BlogImage");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detail).HasColumnType("text");

                entity.Property(e => e.Extension).HasMaxLength(50);

                entity.Property(e => e.Headline).HasColumnType("text");

                entity.Property(e => e.Height).HasDefaultValueSql("((0))");

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.IsConfirm).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.Width).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.BlogImages)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_BlogImage_Blog");
            });

            modelBuilder.Entity<BlogTag>(entity =>
            {
                entity.ToTable("BlogTag");

                entity.Property(e => e.BlogId).HasColumnName("BlogID");

                entity.Property(e => e.IsConfirm).HasDefaultValueSql("((0))");

                entity.Property(e => e.RowNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(250);
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("Brand");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Detail).HasColumnType("text");

                entity.Property(e => e.Extension).HasMaxLength(50);

                entity.Property(e => e.Headline).HasColumnType("text");

                entity.Property(e => e.Height).HasDefaultValueSql("((0))");

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.IsConfirm).HasDefaultValueSql("((0))");

                entity.Property(e => e.RowNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.Url)
                    .HasMaxLength(50)
                    .HasColumnName("URL");

                entity.Property(e => e.Width).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment1)
                    .HasColumnType("text")
                    .HasColumnName("Comment");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.IsConfirm).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Rate).HasDefaultValueSql("((0))");

                entity.Property(e => e.Subject).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<ContactForm>(entity =>
            {
                entity.ToTable("ContactForm");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.IsConfirm).HasDefaultValueSql("((0))");

                entity.Property(e => e.Message).HasColumnType("text");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Subject).HasMaxLength(50);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(2);

                entity.Property(e => e.Language).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.ToTable("Coupon");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsConfirm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Detail).HasColumnType("text");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Extension).HasMaxLength(50);

                entity.Property(e => e.Facebook).HasMaxLength(50);

                entity.Property(e => e.Gender).HasDefaultValueSql("((0))");

                entity.Property(e => e.Headline).HasColumnType("text");

                entity.Property(e => e.Height).HasDefaultValueSql("((0))");

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.Instagram).HasMaxLength(50);

                entity.Property(e => e.IsAgreement).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsConfirm).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsEmailView).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsFacebookView).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsInstagramView).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsLinkedinVİew).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsRemember).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTwitterView).HasDefaultValueSql("((1))");

                entity.Property(e => e.Lastname).HasMaxLength(50);

                entity.Property(e => e.Likes).HasDefaultValueSql("((0))");

                entity.Property(e => e.Linkedin).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PasswordNew).HasMaxLength(50);

                entity.Property(e => e.PasswordNewConfirm).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RowNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.Twitter).HasMaxLength(50);

                entity.Property(e => e.Views).HasDefaultValueSql("((0))");

                entity.Property(e => e.Width).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("District");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_District_City");
            });

            modelBuilder.Entity<Editor>(entity =>
            {
                entity.ToTable("Editor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Detail).HasColumnType("text");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Extension).HasMaxLength(50);

                entity.Property(e => e.Headline).HasColumnType("text");

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.IsConfirm).HasDefaultValueSql("((0))");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Url).HasColumnName("URL");
            });

            modelBuilder.Entity<Like>(entity =>
            {
                entity.ToTable("Like");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.LikesNavigation)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Like_Customer");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.LikesNavigation)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Like_Product");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Message");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Message1)
                    .HasColumnType("text")
                    .HasColumnName("Message");

                entity.Property(e => e.RecipientId).HasColumnName("RecipientID");

                entity.Property(e => e.SenderId).HasColumnName("SenderID");
            });

            modelBuilder.Entity<Neighborhood>(entity =>
            {
                entity.ToTable("Neighborhood");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<Newsletter>(entity =>
            {
                entity.ToTable("Newsletter");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gsm).HasMaxLength(50);

                entity.Property(e => e.IsConfirm).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AdressId).HasColumnName("AdressID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.ShipperId).HasColumnName("ShipperID");

                entity.HasOne(d => d.Adress)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.AdressId)
                    .HasConstraintName("FK_Order_Address");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Order_Customer");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_Order_Payment");

                entity.HasOne(d => d.Shipper)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ShipperId)
                    .HasConstraintName("FK_Order_Shipper");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColorId).HasColumnName("ColorID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SizeId).HasColumnName("SizeID");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_OrderDetail_ProductColor");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderDetail_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetail_Product");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.SizeId)
                    .HasConstraintName("FK_OrderDetail_ProductSize");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Detail).HasColumnType("text");

                entity.Property(e => e.Discount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.Extension).HasMaxLength(50);

                entity.Property(e => e.Headline).HasColumnType("text");

                entity.Property(e => e.Height).HasDefaultValueSql("((0))");

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.IsConfirm).HasDefaultValueSql("((0))");

                entity.Property(e => e.Likes).HasDefaultValueSql("((0))");

                entity.Property(e => e.Price).HasDefaultValueSql("((0))");

                entity.Property(e => e.RowNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.Views).HasDefaultValueSql("((0))");

                entity.Property(e => e.Width).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Brand");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_ProductCat");
            });

            modelBuilder.Entity<ProductCat>(entity =>
            {
                entity.ToTable("ProductCat");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.Detail).HasColumnType("text");

                entity.Property(e => e.Extension).HasMaxLength(50);

                entity.Property(e => e.Headline).HasColumnType("text");

                entity.Property(e => e.Height).HasDefaultValueSql("((0))");

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.IsConfirm).HasDefaultValueSql("((0))");

                entity.Property(e => e.RowNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.Width).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ProductColor>(entity =>
            {
                entity.ToTable("ProductColor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.IsConfirm).HasDefaultValueSql("((1))");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductColors)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductColor_Product");
            });

            modelBuilder.Entity<ProductFile>(entity =>
            {
                entity.ToTable("ProductFile");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detail).HasColumnType("text");

                entity.Property(e => e.Extension).HasMaxLength(50);

                entity.Property(e => e.Headline).HasColumnType("text");

                entity.Property(e => e.IsConfirm).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.RowNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ProductFiles)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductFile_Product");
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.ToTable("ProductImage");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detail).HasColumnType("text");

                entity.Property(e => e.Extension).HasMaxLength(50);

                entity.Property(e => e.Headline).HasColumnType("text");

                entity.Property(e => e.Height).HasDefaultValueSql("((0))");

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.IsConfirm).HasDefaultValueSql("((1))");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.Width).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ProductImages)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_ProductImage_Product");
            });

            modelBuilder.Entity<ProductSize>(entity =>
            {
                entity.ToTable("ProductSize");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsConfirm).HasDefaultValueSql("((1))");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Size).HasMaxLength(50);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSizes)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductSize_Product");
            });

            modelBuilder.Entity<Shipper>(entity =>
            {
                entity.ToTable("Shipper");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Price).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrakingNumber).HasMaxLength(50);

                entity.Property(e => e.Url).HasColumnName("URL");
            });

            modelBuilder.Entity<Site>(entity =>
            {
                entity.ToTable("Site");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.Address).HasColumnType("text");

                entity.Property(e => e.AdminEmail).HasMaxLength(50);

                entity.Property(e => e.AdminName).HasMaxLength(50);

                entity.Property(e => e.ContactInfo).HasColumnType("text");

                entity.Property(e => e.CountryPhoneCode).HasMaxLength(50);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Error).HasColumnType("text");

                entity.Property(e => e.Facebook).HasMaxLength(50);

                entity.Property(e => e.Faks).HasMaxLength(50);

                entity.Property(e => e.FaviconExtension).HasMaxLength(50);

                entity.Property(e => e.FaviconImage).HasMaxLength(50);

                entity.Property(e => e.Instagram).HasMaxLength(50);

                entity.Property(e => e.Intro).HasColumnType("text");

                entity.Property(e => e.IntroExtension).HasMaxLength(50);

                entity.Property(e => e.IntroImage).HasMaxLength(50);

                entity.Property(e => e.Keywords).HasColumnType("text");

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.LogoExtension).HasMaxLength(50);

                entity.Property(e => e.LogoImage).HasMaxLength(50);

                entity.Property(e => e.Maps).HasColumnType("text");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PasswordNew).HasMaxLength(50);

                entity.Property(e => e.PasswordNewConfirm).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Phone2).HasMaxLength(50);

                entity.Property(e => e.Popup).HasMaxLength(50);

                entity.Property(e => e.PopupExtension).HasMaxLength(50);

                entity.Property(e => e.PopupImage).HasMaxLength(50);

                entity.Property(e => e.PopupTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PopupUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PopupURL");

                entity.Property(e => e.Shift).HasColumnType("text");

                entity.Property(e => e.Smtppassword)
                    .HasMaxLength(50)
                    .HasColumnName("SMTPPassword");

                entity.Property(e => e.Smtpport)
                    .HasMaxLength(50)
                    .HasColumnName("SMTPPort");

                entity.Property(e => e.Smtpserver)
                    .HasMaxLength(50)
                    .HasColumnName("SMTPServer");

                entity.Property(e => e.Smtpssl).HasColumnName("SMTPSSL");

                entity.Property(e => e.Smtpuser)
                    .HasMaxLength(50)
                    .HasColumnName("SMTPUser");

                entity.Property(e => e.Twitter).HasMaxLength(50);

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.Property(e => e.Youtube).HasMaxLength(50);
            });

            modelBuilder.Entity<Slide>(entity =>
            {
                entity.ToTable("Slide");

                entity.Property(e => e.SlideId).HasColumnName("SlideID");

                entity.Property(e => e.ButtonText).HasMaxLength(50);

                entity.Property(e => e.Detail).HasColumnType("text");

                entity.Property(e => e.Extension).HasMaxLength(50);

                entity.Property(e => e.Headline).HasColumnType("text");

                entity.Property(e => e.Height).HasDefaultValueSql("((0))");

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.IsConfirm).HasDefaultValueSql("((0))");

                entity.Property(e => e.OffCard).HasMaxLength(50);

                entity.Property(e => e.RowNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.Subtitle).HasMaxLength(250);

                entity.Property(e => e.Target).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .HasColumnName("URL");

                entity.Property(e => e.Width).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Street>(entity =>
            {
                entity.ToTable("Street");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.NeighborhoodId).HasColumnName("NeighborhoodID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
