using BlazorSalaryAppV5.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSalaryAppV5.Server.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<SalaryData> Salaries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed SalaryData Table

            modelBuilder.Entity<SalaryData>().HasData(new SalaryData
            {
                ID = 1,
                Department = "Teach & Learning: Special Education Dpt",
                College = "Education, College of",
                Division = "Academic Affairs",
                JobTitle = "Office & Admin Special Interme",
                PayYearly = 50112f,
                PayYTD = 24092.31f

            });

            modelBuilder.Entity<SalaryData>().HasData(new SalaryData
            {
                ID = 2,
                Department = "Social & Behavioral Science, College of",
                College = "Social & Behavioral Science, College of",
                Division = "Academic Affairs",
                JobTitle = "Office & Admin Special Senior",
                PayYearly = 54768f,
                PayYTD = 26330.77f
            });

            modelBuilder.Entity<SalaryData>().HasData(new SalaryData
            {
                ID = 3,
                Department = "Facilities Services",
                College = "Facilities Management",
                Division = "Finance and Administration",
                JobTitle = "Administrative Mgt Director 1",
                PayYearly = 97635f,
                PayYTD = 46939.90f
            });

        }
    }
}
