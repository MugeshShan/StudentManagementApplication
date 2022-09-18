using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagement.Api.Migrations
{
    public partial class ChangeInTableData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "RollNumber",
                keyValue: "11A125");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "RollNumber",
                keyValue: "8A123");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "RollNumber",
                keyValue: "9A124");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FathersName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "StudentMarks",
                keyColumn: "Id",
                keyValue: 1,
                column: "RollNumber",
                value: "8A001");

            migrationBuilder.UpdateData(
                table: "StudentMarks",
                keyColumn: "Id",
                keyValue: 2,
                column: "RollNumber",
                value: "8A002");

            migrationBuilder.UpdateData(
                table: "StudentMarks",
                keyColumn: "Id",
                keyValue: 3,
                column: "RollNumber",
                value: "8A003");

            migrationBuilder.InsertData(
                table: "StudentMarks",
                columns: new[] { "Id", "English", "Maths", "RollNumber", "Science", "Social", "Tamil", "TotalMarks" },
                values: new object[,]
                {
                    { 4, 75, 75, "8A004", 75, 75, 75, 400 },
                    { 5, 70, 70, "8A005", 70, 70, 70, 375 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "RollNumber", "Address", "Class", "Dob", "Email", "FathersName", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { "8A001", "Chidambaram", "VIII", "11-09-2009", "adhi.madhan@gmail.com", "Madhan", "Adhi", "9952744908" },
                    { "8A002", "Cuddalore", "VIII", "05-09-2009", "balu.dhileep@gmail.com", "Dhileep", "Balu", "9488940491" },
                    { "8A003", "Pondicherry", "VIII", "17-12-2009", "chinthan.vikram@gmail.com", "Vikram", "Chinthan", "8610681447" },
                    { "8A004", "Chidambaram", "VIII", "17-11-2009", "dinesh.aravind@gmail.com", "Aravind", "Dinesh", "9443877178" },
                    { "8A005", "Chidambaram", "VIII", "17-02-2010", "ezhil.mohan@gmail.com", "Mohan", "Ezhil", "9488046422" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentMarks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StudentMarks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "RollNumber",
                keyValue: "8A001");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "RollNumber",
                keyValue: "8A002");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "RollNumber",
                keyValue: "8A003");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "RollNumber",
                keyValue: "8A004");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "RollNumber",
                keyValue: "8A005");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FathersName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Students");

            migrationBuilder.UpdateData(
                table: "StudentMarks",
                keyColumn: "Id",
                keyValue: 1,
                column: "RollNumber",
                value: "8A123");

            migrationBuilder.UpdateData(
                table: "StudentMarks",
                keyColumn: "Id",
                keyValue: 2,
                column: "RollNumber",
                value: "9A124");

            migrationBuilder.UpdateData(
                table: "StudentMarks",
                keyColumn: "Id",
                keyValue: 3,
                column: "RollNumber",
                value: "11A125");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "RollNumber", "Class", "Dob", "Name" },
                values: new object[,]
                {
                    { "11A125", "XI", "17-12-2000", "Sagar" },
                    { "8A123", "VIII", "11-09-2002", "Mugesh" },
                    { "9A124", "IX", "05-09-2001", "Prakash" }
                });
        }
    }
}
