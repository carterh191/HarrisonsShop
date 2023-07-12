﻿// <auto-generated />
using HarrisonsShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HarrisonsShop.Migrations
{
    [DbContext(typeof(HarrisonsShopDbContext))]
    [Migration("20220607195917_InitialMigraation")]
    partial class InitialMigraation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HarrisonsShop.Models.Category", b =>
            {
                b.Property<int>("CategoryId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                b.Property<string>("CategoryName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Description")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("CategoryId");

                b.ToTable("Categories");
            });

            modelBuilder.Entity("HarrisonsShop.Models.Pie", b =>
            {
                b.Property<int>("PieId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PieId"), 1L, 1);

                b.Property<string>("AllergyInformation")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("CategoryId")
                    .HasColumnType("int");

                b.Property<string>("ImageThumbnailUrl")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ImageUrl")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("InStock")
                    .HasColumnType("bit");

                b.Property<bool>("IsPieOfTheWeek")
                    .HasColumnType("bit");

                b.Property<string>("LongDescription")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<decimal>("Price")
                    .HasColumnType("decimal(18,2)");

                b.Property<string>("ShortDescription")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("PieId");

                b.HasIndex("CategoryId");

                b.ToTable("Pies");
            });

            modelBuilder.Entity("HarrisonsShop.Models.Pie", b =>
            {
                b.HasOne("HarrisonsShop.Models.Category", "Category")
                    .WithMany("Pies")
                    .HasForeignKey("CategoryId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Category");
            });

            modelBuilder.Entity("HarrisonsShop.Models.Category", b =>
            {
                b.Navigation("Pies");
            });
#pragma warning restore 612, 618
        }
    }
}
