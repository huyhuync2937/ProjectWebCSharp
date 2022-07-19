using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Project2.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductDetail> ProductDetails { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("MyConStr"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bill");

                entity.Property(e => e.BillId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BillID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DateTrading)
                    .HasColumnType("date")
                    .HasColumnName("Date Trading");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Customer)
                    .WithMany()
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bill__CustomerID__0E6E26BF");

                entity.HasOne(d => d.Product)
                    .WithMany()
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bill__ProductID__0F624AF8");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.TypeName)
                    .HasName("PK_Category_HE153639_SE1606");

                entity.ToTable("Category");

                entity.Property(e => e.TypeName).HasMaxLength(100);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.TypeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TypeID");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.DateAdd)
                    .HasColumnType("date")
                    .HasColumnName("Date add");

                entity.Property(e => e.Image).HasMaxLength(100);

                entity.Property(e => e.NumberOfInventory).HasColumnName("Number of Inventory");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ProductDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Product_Detail");

                entity.Property(e => e.Brand).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.Ingredient).HasColumnType("text");

                entity.Property(e => e.Origin).HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.TypeName).HasMaxLength(100);

                entity.Property(e => e.UserManual).HasColumnType("text");

                entity.HasOne(d => d.Product)
                    .WithMany()
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Product D__Produ__123EB7A3");

                entity.HasOne(d => d.TypeNameNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.TypeName)
                    .HasConstraintName("FK__Product D__TypeN__2B0A656D");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK_Customer");

                entity.ToTable("User");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK_Customer Detail_HE153639_SE1606");

                entity.ToTable("User_Detail");

                entity.Property(e => e.CustomerId)
                    .ValueGeneratedNever()
                    .HasColumnName("CustomerID");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.HasOne(d => d.Customer)
                    .WithOne(p => p.UserDetail)
                    .HasForeignKey<UserDetail>(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customer __Custo__10566F31");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
