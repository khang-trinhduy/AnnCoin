using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnConn.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "q4",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "q5a",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q5b",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q5c",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q6a",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q6b",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q6c",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q6d",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q7a",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q7b",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q7c",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q7d",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q7e",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q8a",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q8b",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q8c",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q8d",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q8e",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q8f",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "supporter",
                table: "Customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "q4",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q5a",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q5b",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q5c",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q6a",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q6b",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q6c",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q6d",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q7a",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q7b",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q7c",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q7d",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q7e",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q8a",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q8b",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q8c",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q8d",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q8e",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q8f",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "supporter",
                table: "Customers");
        }
    }
}
