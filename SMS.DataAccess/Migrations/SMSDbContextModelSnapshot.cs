﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMS.DataAccess;

namespace SMS.DataAccess.Migrations
{
    [DbContext(typeof(SMSDbContext))]
    partial class SMSDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<int>("Min_mark")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

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
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NameWithInitials")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

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
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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

            modelBuilder.Entity("SMS.Models.SubjectEnroll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SubjectEnroll");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            StudentId = 1,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 2,
                            StudentId = 1,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 3,
                            StudentId = 1,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 4,
                            StudentId = 2,
                            SubjectId = 1
                        });
                });

            modelBuilder.Entity("SMS.Models.SubjectMarks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EnrollId")
                        .HasColumnType("int");

                    b.Property<int>("Marks")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SubjectMarks");
                });
#pragma warning restore 612, 618
        }
    }
}
