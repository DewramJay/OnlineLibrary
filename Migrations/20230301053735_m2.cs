using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace prrr.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublisherRegNo",
                table: "staff");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "staff",
                newName: "UserPassword");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "staff",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "staff",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "StaffRegNo",
                table: "staff",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "StaffUserName",
                table: "staff",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "staff");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "staff");

            migrationBuilder.DropColumn(
                name: "StaffRegNo",
                table: "staff");

            migrationBuilder.DropColumn(
                name: "StaffUserName",
                table: "staff");

            migrationBuilder.RenameColumn(
                name: "UserPassword",
                table: "staff",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "PublisherRegNo",
                table: "staff",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
