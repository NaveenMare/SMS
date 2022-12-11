﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMS.DataAccess;

namespace SMS.DataAccess.Migrations
{
    [DbContext(typeof(SMSDbContext))]
    [Migration("20221211035900_DataSeedGrades")]
    partial class DataSeedGrades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SMS.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Max_mark")
                        .HasColumnType("int");

                    b.Property<int>("Min_mark")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Max_mark = 9,
                            Min_mark = 0,
                            Name = "D"
                        },
                        new
                        {
                            Id = 2,
                            Max_mark = 19,
                            Min_mark = 10,
                            Name = "C-"
                        },
                        new
                        {
                            Id = 3,
                            Max_mark = 29,
                            Min_mark = 20,
                            Name = "C"
                        },
                        new
                        {
                            Id = 4,
                            Max_mark = 39,
                            Min_mark = 30,
                            Name = "C+"
                        },
                        new
                        {
                            Id = 5,
                            Max_mark = 49,
                            Min_mark = 40,
                            Name = "B-"
                        },
                        new
                        {
                            Id = 6,
                            Max_mark = 59,
                            Min_mark = 50,
                            Name = "B"
                        },
                        new
                        {
                            Id = 7,
                            Max_mark = 69,
                            Min_mark = 60,
                            Name = "B+"
                        },
                        new
                        {
                            Id = 8,
                            Max_mark = 79,
                            Min_mark = 70,
                            Name = "A-"
                        },
                        new
                        {
                            Id = 9,
                            Max_mark = 89,
                            Min_mark = 80,
                            Name = "A"
                        },
                        new
                        {
                            Id = 10,
                            Max_mark = 100,
                            Min_mark = 90,
                            Name = "A+"
                        });
                });

            modelBuilder.Entity("SMS.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameWithInitials")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Kelaniya",
                            Email = "aravindaperera@gmail.com",
                            FirstName = "Aravinda",
                            LastName = "Perera",
                            NameWithInitials = "H.A.Perera"
                        });
                });

            modelBuilder.Entity("SMS.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Credits = 3,
                            Name = "Science"
                        },
                        new
                        {
                            Id = 2,
                            Credits = 3,
                            Name = "English"
                        },
                        new
                        {
                            Id = 3,
                            Credits = 3,
                            Name = "Maths"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
