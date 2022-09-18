using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagement.Api.Migrations
{
    public partial class InitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    RollNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tamil = table.Column<int>(type: "int", nullable: false),
                    English = table.Column<int>(type: "int", nullable: false),
                    Maths = table.Column<int>(type: "int", nullable: false),
                    Science = table.Column<int>(type: "int", nullable: false),
                    Social = table.Column<int>(type: "int", nullable: false),
                    TotalMarks = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.RollNumber);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "RollNumber", "Class", "Dob", "English", "Maths", "Name", "Science", "Social", "Tamil", "TotalMarks" },
                values: new object[] { 1, "XI", "11-09-1996", 74, 98, "Mugesh", 99, 85, 89, 445 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "RollNumber", "Class", "Dob", "English", "Maths", "Name", "Science", "Social", "Tamil", "TotalMarks" },
                values: new object[] { 2, "XI", "11-09-1996", 74, 98, "Prakash", 99, 85, 89, 445 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "RollNumber", "Class", "Dob", "English", "Maths", "Name", "Science", "Social", "Tamil", "TotalMarks" },
                values: new object[] { 3, "XI", "11-09-1996", 74, 98, "Sagar", 99, 85, 89, 445 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
