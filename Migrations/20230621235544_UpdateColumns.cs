using Microsoft.EntityFrameworkCore.Migrations;

namespace byu_w.Migrations
{
    public partial class UpdateColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Student",
                newName: "Last Name");

            migrationBuilder.RenameColumn(
                name: "FirstMidName",
                table: "Student",
                newName: "First Name");

            migrationBuilder.RenameColumn(
                name: "EnrollmentDate",
                table: "Student",
                newName: "Enrollment Date");

            migrationBuilder.AlterColumn<string>(
                name: "Last Name",
                table: "Student",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "First Name",
                table: "Student",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Last Name",
                table: "Student",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "First Name",
                table: "Student",
                newName: "FirstMidName");

            migrationBuilder.RenameColumn(
                name: "Enrollment Date",
                table: "Student",
                newName: "EnrollmentDate");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstMidName",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
