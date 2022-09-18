using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagement.Api.Migrations
{
    public partial class ChangeInData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "RollNumber",
                keyValue: "11A123");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "RollNumber",
                keyValue: "11A124");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "RollNumber",
                keyValue: "11A125",
                column: "Dob",
                value: "17-12-2000");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "RollNumber", "Class", "Dob", "Name" },
                values: new object[] { "8A123", "VIII", "11-09-2002", "Mugesh" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "RollNumber", "Class", "Dob", "Name" },
                values: new object[] { "9A124", "IX", "05-09-2001", "Prakash" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "RollNumber",
                keyValue: "8A123");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "RollNumber",
                keyValue: "9A124");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "RollNumber",
                keyValue: "11A125",
                column: "Dob",
                value: "11-09-1996");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "RollNumber", "Class", "Dob", "Name" },
                values: new object[] { "11A123", "XI", "11-09-1996", "Mugesh" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "RollNumber", "Class", "Dob", "Name" },
                values: new object[] { "11A124", "XI", "11-09-1996", "Prakash" });
        }
    }
}
