﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OneToMany;

namespace OneToMany.Migrations
{
    [DbContext(typeof(DepartmentContext))]
    [Migration("20210930123146_Phase1")]
    partial class Phase1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("OneToMany.Department", b =>
                {
                    b.Property<int>("DepID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DepName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("DepID");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("OneToMany.Employee", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("DepartmentDepID")
                        .HasColumnType("integer");

                    b.Property<string>("EmpEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EmpName")
                        .HasColumnType("text");

                    b.HasKey("EmpId");

                    b.HasIndex("DepartmentDepID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("OneToMany.Employee", b =>
                {
                    b.HasOne("OneToMany.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentDepID");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("OneToMany.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
