using CURD.Application.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CURD.Application.Server
{
    public class SchoolDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Student>().HasData(
                new
                {
                    StudentId = Guid.NewGuid().ToString(),
                    FirstName = "Jayasimha",
                    LastName = "Vaddi",
                    Department = "IT"
                },
                new
                {
                    StudentId = Guid.NewGuid().ToString(),
                    FirstName = "Harish",
                    LastName = "Kumar",
                    Department = "IT"
                });
        }
    }
}
