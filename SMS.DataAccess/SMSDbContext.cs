﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Models;

namespace SMS.DataAccess
{
    public class SMSDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }    
        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Database=SMSDB;Trusted_Connection=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 1,
                NameWithInitials = "H.A.Perera",
                FirstName = "Aravinda",
                LastName = "Perera",
                Email = "aravindaperera@gmail.com",
                Address = "Kelaniya"
            });

            modelBuilder.Entity<Subject>().HasData(new Subject[]
            {
                new Subject {Id = 1, Name = "Science", Credits= 3},
                new Subject {Id = 2, Name = "English", Credits= 3},
                new Subject {Id = 3, Name = "Maths", Credits= 3},

            });

            modelBuilder.Entity<Grade>().HasData(new Grade[]
            {
                new Grade {Id = 1, Name = "D", Min_mark = 0 , Max_mark = 9},
                new Grade {Id = 2, Name = "C-", Min_mark = 10 , Max_mark = 19},
                new Grade {Id = 3, Name = "C", Min_mark = 20 , Max_mark = 29},
                new Grade {Id = 4, Name = "C+", Min_mark = 30 , Max_mark = 39},
                new Grade {Id = 5, Name = "B-", Min_mark = 40 , Max_mark = 49},
                new Grade {Id = 6, Name = "B", Min_mark = 50 , Max_mark = 59},
                new Grade {Id = 7, Name = "B+", Min_mark = 60 , Max_mark = 69},
                new Grade {Id = 8, Name = "A-", Min_mark = 70 , Max_mark = 79},
                new Grade {Id = 9, Name = "A", Min_mark = 80 , Max_mark = 89},
                new Grade {Id = 10, Name = "A+", Min_mark = 90 , Max_mark = 100}

            });
        }
    }
}
