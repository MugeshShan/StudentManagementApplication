using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagement.Api.Migrations
{
    public partial class ChangeInDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StudentMarks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "English", "Maths", "RollNumber", "Science", "Social", "Tamil", "TotalMarks" },
                values: new object[] { 95, 95, "8A123", 95, 95, 95, 475 });

            migrationBuilder.UpdateData(
                table: "StudentMarks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "English", "Maths", "RollNumber", "Science", "Social", "Tamil", "TotalMarks" },
                values: new object[] { 90, 90, "9A124", 90, 90, 90, 450 });

            migrationBuilder.UpdateData(
                table: "StudentMarks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "English", "Maths", "Science", "Tamil", "TotalMarks" },
                values: new object[] { 85, 85, 85, 85, 425 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StudentMarks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "English", "Maths", "RollNumber", "Science", "Social", "Tamil", "TotalMarks" },
                values: new object[] { 74, 98, "11A123", 99, 85, 0, 445 });

            migrationBuilder.UpdateData(
                table: "StudentMarks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "English", "Maths", "RollNumber", "Science", "Social", "Tamil", "TotalMarks" },
                values: new object[] { 74, 98, "11A124", 99, 85, 89, 445 });

            migrationBuilder.UpdateData(
                table: "StudentMarks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "English", "Maths", "Science", "Tamil", "TotalMarks" },
                values: new object[] { 74, 98, 99, 89, 445 });
        }
    }
}
