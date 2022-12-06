﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantASP.Models;

#nullable disable

namespace mgonzales3312Final21.Migrations
{
    [DbContext(typeof(RestaurantDbContext))]
    [Migration("20221206213406_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("RestaurantASP.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<double>("Rating")
                        .HasColumnType("REAL");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Tossed")
                        .HasColumnType("INTEGER");

                    b.HasKey("RestaurantID");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("RestaurantASP.Models.Review", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<double>("Rating")
                        .HasColumnType("REAL");

                    b.Property<int>("RestaurantID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Tossed")
                        .HasColumnType("INTEGER");

                    b.HasKey("ReviewID");

                    b.HasIndex("RestaurantID");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("RestaurantASP.Models.Review", b =>
                {
                    b.HasOne("RestaurantASP.Models.Restaurant", "Restaurant")
                        .WithMany("Reviews")
                        .HasForeignKey("RestaurantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestaurantASP.Models.Restaurant", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
