using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ORM2;

namespace ORM2.Migrations
{
    [DbContext(typeof(BloggingContext))]
    [Migration("20170222121806_Migrations_")]
    partial class Migrations_
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ORM2.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("HomePageUrl");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ProductModels");
                });

            modelBuilder.Entity("ORM2.UpdateModel", b =>
                {
                    b.Property<int>("UpdateId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("UpdateId");

                    b.HasIndex("Id");

                    b.ToTable("UpdateModels");
                });

            modelBuilder.Entity("ORM2.UpdateModel", b =>
                {
                    b.HasOne("ORM2.ProductModel", "ProductModels")
                        .WithMany("UpdateModels")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
