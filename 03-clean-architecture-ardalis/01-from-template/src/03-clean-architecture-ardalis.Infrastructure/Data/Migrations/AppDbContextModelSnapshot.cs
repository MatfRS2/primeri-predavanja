﻿// <auto-generated />
using _03_clean_architecture_ardalis.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace _03_clean_architecture_ardalis.Infrastructure.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("_03_clean_architecture_ardalis.Core.ContributorAggregate.Contributor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Contributors");
                });

            modelBuilder.Entity("_03_clean_architecture_ardalis.Core.ContributorAggregate.Contributor", b =>
                {
                    b.OwnsOne("_03_clean_architecture_ardalis.Core.ContributorAggregate.PhoneNumber", "PhoneNumber", b1 =>
                        {
                            b1.Property<int>("ContributorId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("CountryCode")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Extension")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Number")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("ContributorId");

                            b1.ToTable("Contributors");

                            b1.WithOwner()
                                .HasForeignKey("ContributorId");
                        });

                    b.Navigation("PhoneNumber");
                });
#pragma warning restore 612, 618
        }
    }
}
