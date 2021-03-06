// <auto-generated />
using BlazorSalaryAppV5.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorSalaryAppV5.Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220207011356_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazorSalaryAppV5.Shared.SalaryData", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("College")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Division")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PayYTD")
                        .HasColumnType("real");

                    b.Property<float>("PayYearly")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.ToTable("Salaries");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            College = "Education, College of",
                            Department = "Teach & Learning: Special Education Dpt",
                            Division = "Academic Affairs",
                            JobTitle = "Office & Admin Special Interme",
                            PayYTD = 24092.31f,
                            PayYearly = 50112f
                        },
                        new
                        {
                            ID = 2,
                            College = "Social & Behavioral Science, College of",
                            Department = "Social & Behavioral Science, College of",
                            Division = "Academic Affairs",
                            JobTitle = "Office & Admin Special Senior",
                            PayYTD = 26330.77f,
                            PayYearly = 54768f
                        },
                        new
                        {
                            ID = 3,
                            College = "Facilities Management",
                            Department = "Facilities Services",
                            Division = "Finance and Administration",
                            JobTitle = "Administrative Mgt Director 1",
                            PayYTD = 46939.9f,
                            PayYearly = 97635f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
