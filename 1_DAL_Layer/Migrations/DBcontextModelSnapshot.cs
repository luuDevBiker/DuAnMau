﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1_DAL_Layer.DataBaseContext;

namespace _1_DAL_Layer.Migrations
{
    [DbContext(typeof(DBcontext))]
    partial class DBcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("_1_DAL_Layer.Entitys.Customer", b =>
                {
                    b.Property<string>("Ct_PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Ct_Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ct_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Ct_Sex")
                        .HasColumnType("int");

                    b.Property<string>("Ep_Code")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Ct_PhoneNumber");

                    b.HasIndex("Ep_Code");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("_1_DAL_Layer.Entitys.Employee", b =>
                {
                    b.Property<string>("Ep_Code")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Ep_Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ep_Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Ep_Id")
                        .HasColumnType("int");

                    b.Property<string>("Ep_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ep_Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Ep_Role")
                        .HasColumnType("int");

                    b.Property<bool>("Ep_Status")
                        .HasColumnType("bit");

                    b.Property<bool>("Ep_StatusPassword")
                        .HasColumnType("bit");

                    b.HasKey("Ep_Code");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("_1_DAL_Layer.Entitys.Products", b =>
                {
                    b.Property<string>("Prd_Code")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Ep_Code")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Prd_ExportPrice")
                        .HasColumnType("int");

                    b.Property<int>("Prd_Id")
                        .HasColumnType("int");

                    b.Property<byte[]>("Prd_Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Prd_ImportPrice")
                        .HasColumnType("int");

                    b.Property<string>("Prd_Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Prd_Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Prd_Quantity")
                        .HasColumnType("int");

                    b.HasKey("Prd_Code");

                    b.HasIndex("Ep_Code");

                    b.ToTable("Hangs");
                });

            modelBuilder.Entity("_1_DAL_Layer.Entitys.Customer", b =>
                {
                    b.HasOne("_1_DAL_Layer.Entitys.Employee", "Employee")
                        .WithMany("Customer")
                        .HasForeignKey("Ep_Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("_1_DAL_Layer.Entitys.Products", b =>
                {
                    b.HasOne("_1_DAL_Layer.Entitys.Employee", "Employee")
                        .WithMany("Products")
                        .HasForeignKey("Ep_Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("_1_DAL_Layer.Entitys.Employee", b =>
                {
                    b.Navigation("Customer");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
