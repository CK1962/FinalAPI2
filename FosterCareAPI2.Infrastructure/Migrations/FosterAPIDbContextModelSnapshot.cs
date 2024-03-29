﻿// <auto-generated />
using FosterCareAPI2.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FosterCareAPI2.Infrastructure.Migrations
{
    [DbContext(typeof(FosterAPIDbContext))]
    partial class FosterAPIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.ToTable("Child");

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
#pragma warning restore 612, 618
        }
    }
}
