﻿// <auto-generated />
using FosterCareAPI2.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FosterCareAPI2.Infrastructure2.Migrations
{
    [DbContext(typeof(FosterAPIDbContext))]
    [Migration("20190905003523_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("FosterCareAPI2.Core.Models.Child", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Dob");

                    b.Property<string>("MoveInDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Children");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Dob = "01/01/01",
                            MoveInDate = "08/08/08",
                            Name = "Ashton"
                        },
                        new
                        {
                            Id = 2,
                            Dob = "01/01/96",
                            MoveInDate = "09/09/09",
                            Name = "Dylan"
                        },
                        new
                        {
                            Id = 3,
                            Dob = "01/01/05",
                            MoveInDate = "02/02/12",
                            Name = "Lilly"
                        },
                        new
                        {
                            Id = 4,
                            Dob = "01/01/12",
                            MoveInDate = "03/03/13",
                            Name = "Mariah"
                        });
                });

            modelBuilder.Entity("FosterCareAPI2.Core.Models.ChildHome", b =>
                {
                    b.Property<int>("ChildId");

                    b.Property<int>("HouseId");

                    b.HasKey("ChildId", "HouseId");

                    b.HasIndex("HouseId");

                    b.ToTable("ChildHomes");
                });

            modelBuilder.Entity("FosterCareAPI2.Core.Models.House", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Home");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Lubbock",
                            Name = "Keslin"
                        });
                });

            modelBuilder.Entity("FosterCareAPI2.Core.Models.ChildHome", b =>
                {
                    b.HasOne("FosterCareAPI2.Core.Models.Child", "Child")
                        .WithMany("ChildHomes")
                        .HasForeignKey("ChildId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FosterCareAPI2.Core.Models.House", "House")
                        .WithMany("ChildHomes")
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}