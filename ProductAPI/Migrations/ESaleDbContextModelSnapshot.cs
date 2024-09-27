﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductAPI.Models;

#nullable disable

namespace ProductAPI.Migrations
{
    [DbContext(typeof(ESaleDbContext))]
    partial class ESaleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("Entities.Models.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Cities", (string)null);
                });

            modelBuilder.Entity("Entities.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("City_ID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("City_ID");

                    b.ToTable("Customers", (string)null);
                });

            modelBuilder.Entity("Entities.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("City_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Customer_ID")
                        .HasColumnType("int");

                    b.Property<string>("OrderDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequiredDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("City_ID");

                    b.HasIndex("Customer_ID");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("Entities.Models.OrderDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("Order_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Product_ID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Order_ID");

                    b.HasIndex("Product_ID");

                    b.ToTable("OrderDetails", (string)null);
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("Category_ID")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrlBig")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrlSmall")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int?>("Supplier_ID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Category_ID");

                    b.HasIndex("Supplier_ID");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("Entities.Models.ProductImage", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Product_ID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Product_ID");

                    b.ToTable("ProductImages", (string)null);
                });

            modelBuilder.Entity("Entities.Models.Supplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Suppliers", (string)null);
                });

            modelBuilder.Entity("Entities.Models.Customer", b =>
                {
                    b.HasOne("Entities.Models.City", "City")
                        .WithMany("Customers")
                        .HasForeignKey("City_ID");

                    b.Navigation("City");
                });

            modelBuilder.Entity("Entities.Models.Order", b =>
                {
                    b.HasOne("Entities.Models.City", "City")
                        .WithMany("Orders")
                        .HasForeignKey("City_ID");

                    b.HasOne("Entities.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Customer_ID");

                    b.Navigation("City");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Entities.Models.OrderDetail", b =>
                {
                    b.HasOne("Entities.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("Order_ID");

                    b.HasOne("Entities.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("Product_ID");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.HasOne("Entities.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("Category_ID");

                    b.HasOne("Entities.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("Supplier_ID");

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Entities.Models.ProductImage", b =>
                {
                    b.HasOne("Entities.Models.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("Product_ID");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Entities.Models.City", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Entities.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("ProductImages");
                });

            modelBuilder.Entity("Entities.Models.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}