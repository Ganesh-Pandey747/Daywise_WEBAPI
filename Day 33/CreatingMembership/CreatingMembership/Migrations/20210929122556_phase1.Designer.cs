﻿// <auto-generated />
using CreatingMembership.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CreatingMembership.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210929122556_phase1")]
    partial class phase1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("CreatingMembership.Models.User", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.Property<int>("Age")
                        .HasMaxLength(3)
                        .HasColumnType("integer");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.HasKey("UserName");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
