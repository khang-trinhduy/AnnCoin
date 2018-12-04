using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnConn.Migrations
{
    public partial class template : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "q8f",
                table: "Customers",
                newName: "q6m");

            migrationBuilder.RenameColumn(
                name: "q8e",
                table: "Customers",
                newName: "q6l");

            migrationBuilder.RenameColumn(
                name: "q8d",
                table: "Customers",
                newName: "q6k");

            migrationBuilder.RenameColumn(
                name: "q8c",
                table: "Customers",
                newName: "q6j");

            migrationBuilder.RenameColumn(
                name: "q8b",
                table: "Customers",
                newName: "q6i");

            migrationBuilder.RenameColumn(
                name: "q8a",
                table: "Customers",
                newName: "q6h");

            migrationBuilder.RenameColumn(
                name: "q7e",
                table: "Customers",
                newName: "q6g");

            migrationBuilder.RenameColumn(
                name: "q7d",
                table: "Customers",
                newName: "q6f");

            migrationBuilder.RenameColumn(
                name: "q7c",
                table: "Customers",
                newName: "q6e");

            migrationBuilder.RenameColumn(
                name: "q7b",
                table: "Customers",
                newName: "q5j");

            migrationBuilder.RenameColumn(
                name: "q7a",
                table: "Customers",
                newName: "q5i");

            migrationBuilder.AlterColumn<bool>(
                name: "q4",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<bool>(
                name: "q5d",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q5e",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q5f",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q5g",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q5h",
                table: "Customers",
                nullable: false,
                defaultValue: false);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.DropColumn(
                name: "q5d",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q5e",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q5f",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q5g",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q5h",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "q6m",
                table: "Customers",
                newName: "q8f");

            migrationBuilder.RenameColumn(
                name: "q6l",
                table: "Customers",
                newName: "q8e");

            migrationBuilder.RenameColumn(
                name: "q6k",
                table: "Customers",
                newName: "q8d");

            migrationBuilder.RenameColumn(
                name: "q6j",
                table: "Customers",
                newName: "q8c");

            migrationBuilder.RenameColumn(
                name: "q6i",
                table: "Customers",
                newName: "q8b");

            migrationBuilder.RenameColumn(
                name: "q6h",
                table: "Customers",
                newName: "q8a");

            migrationBuilder.RenameColumn(
                name: "q6g",
                table: "Customers",
                newName: "q7e");

            migrationBuilder.RenameColumn(
                name: "q6f",
                table: "Customers",
                newName: "q7d");

            migrationBuilder.RenameColumn(
                name: "q6e",
                table: "Customers",
                newName: "q7c");

            migrationBuilder.RenameColumn(
                name: "q5j",
                table: "Customers",
                newName: "q7b");

            migrationBuilder.RenameColumn(
                name: "q5i",
                table: "Customers",
                newName: "q7a");

            migrationBuilder.AlterColumn<int>(
                name: "q4",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
