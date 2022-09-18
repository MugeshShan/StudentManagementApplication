using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagement.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentMarks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RollNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tamil = table.Column<int>(type: "int", nullable: false),
                    English = table.Column<int>(type: "int", nullable: false),
                    Maths = table.Column<int>(type: "int", nullable: false),
                    Science = table.Column<int>(type: "int", nullable: false),
                    Social = table.Column<int>(type: "int", nullable: false),
                    TotalMarks = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentMarks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    RollNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                table: "StudentMarks",
                columns: new[] { "Id", "English", "Maths", "RollNumber", "Science", "Social", "Tamil", "TotalMarks" },
                values: new object[,]
                {
                    { 1, 74, 98, "11A123", 99, 85, 0, 445 },
                    { 2, 74, 98, "11A124", 99, 85, 89, 445 },
                    { 3, 74, 98, "11A125", 99, 85, 89, 445 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "RollNumber", "Class", "Dob", "English", "Maths", "Name", "Science", "Social", "Tamil", "TotalMarks" },
                values: new object[,]
                {
                    { "11A123", "XI", "11-09-1996", 74, 98, "Mugesh", 99, 85, 89, 445 },
                    { "11A124", "XI", "11-09-1996", 74, 98, "Prakash", 99, 85, 89, 445 },
                    { "11A125", "XI", "11-09-1996", 74, 98, "Sagar", 99, 85, 89, 445 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentMarks");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
