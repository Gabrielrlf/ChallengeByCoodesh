﻿// <auto-generated />
using System;
using ChallengeCoodesh_BACK.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChallengeCoodesh_BACK.Infra.Migrations
{
    [DbContext(typeof(EntitiesDbContext))]
    [Migration("20230521191140_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("ChallengeCoodesh_BACK.Domain.Entities.FileUploader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("SellerName")
                        .HasColumnType("TEXT");

                    b.Property<int>("TypeTransaction")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ValueProduct")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("fileUploader");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 5, 21, 16, 11, 40, 606, DateTimeKind.Local).AddTicks(1509),
                            ProductDescription = "DESENVOLVEDOR FULL STACK",
                            SellerName = "ELIANA NOGUEIRA",
                            TypeTransaction = 1,
                            ValueProduct = 155000m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
