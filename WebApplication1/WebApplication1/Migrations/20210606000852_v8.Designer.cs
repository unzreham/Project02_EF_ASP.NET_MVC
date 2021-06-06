﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(PlacesDbContext))]
    [Migration("20210606000852_v8")]
    partial class v8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Address", b =>
                {
                    b.Property<int>("addressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("latitude")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("longitude")
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("placeId")
                        .HasColumnType("int");

                    b.HasKey("addressId");

                    b.HasIndex("placeId")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("WebApplication1.Models.City", b =>
                {
                    b.Property<int>("cityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Population")
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("cityId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("WebApplication1.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("placeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("placeId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("WebApplication1.Models.Place", b =>
                {
                    b.Property<int>("placeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("area")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("cityId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("photo")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("placeName")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("placeId");

                    b.HasIndex("cityId");

                    b.ToTable("Place");
                });

            modelBuilder.Entity("WebApplication1.Models.Address", b =>
                {
                    b.HasOne("WebApplication1.Models.Place", "place")
                        .WithOne("Address")
                        .HasForeignKey("WebApplication1.Models.Address", "placeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("place");
                });

            modelBuilder.Entity("WebApplication1.Models.Comment", b =>
                {
                    b.HasOne("WebApplication1.Models.Place", "place")
                        .WithMany("comments")
                        .HasForeignKey("placeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("place");
                });

            modelBuilder.Entity("WebApplication1.Models.Place", b =>
                {
                    b.HasOne("WebApplication1.Models.City", "city")
                        .WithMany("places")
                        .HasForeignKey("cityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("city");
                });

            modelBuilder.Entity("WebApplication1.Models.City", b =>
                {
                    b.Navigation("places");
                });

            modelBuilder.Entity("WebApplication1.Models.Place", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("comments");
                });
#pragma warning restore 612, 618
        }
    }
}
