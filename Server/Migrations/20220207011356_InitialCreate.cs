using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorSalaryAppV5.Server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Salaries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    College = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Division = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayYearly = table.Column<float>(type: "real", nullable: false),
                    PayYTD = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salaries", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "ID", "College", "Department", "Division", "JobTitle", "PayYTD", "PayYearly" },
                values: new object[] { 1, "Education, College of", "Teach & Learning: Special Education Dpt", "Academic Affairs", "Office & Admin Special Interme", 24092.31f, 50112f });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "ID", "College", "Department", "Division", "JobTitle", "PayYTD", "PayYearly" },
                values: new object[] { 2, "Social & Behavioral Science, College of", "Social & Behavioral Science, College of", "Academic Affairs", "Office & Admin Special Senior", 26330.77f, 54768f });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "ID", "College", "Department", "Division", "JobTitle", "PayYTD", "PayYearly" },
                values: new object[] { 3, "Facilities Management", "Facilities Services", "Finance and Administration", "Administrative Mgt Director 1", 46939.9f, 97635f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Salaries");
        }
    }
}
