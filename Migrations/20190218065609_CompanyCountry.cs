using Microsoft.EntityFrameworkCore.Migrations;

namespace VendorList.Migrations
{
    public partial class CompanyCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AreaCode",
                table: "Blogs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CompanyCountry",
                table: "Blogs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Blogs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Blogs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Blogs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetName",
                table: "Blogs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetNumber",
                table: "Blogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaCode",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CompanyCountry",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "StreetName",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "StreetNumber",
                table: "Blogs");
        }
    }
}
