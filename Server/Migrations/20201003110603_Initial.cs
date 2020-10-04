using Microsoft.EntityFrameworkCore.Migrations;

namespace CURD.Application.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Department = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Department", "FirstName", "LastName" },
                values: new object[] { "b6d8e07a-3b49-40e5-ac3f-686b87e6b33d", "IT", "Jayasimha", "Vaddi" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Department", "FirstName", "LastName" },
                values: new object[] { "b44b35c1-02b1-43f8-8cfe-ed35fb0db977", "IT", "Harish", "Kumar" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
