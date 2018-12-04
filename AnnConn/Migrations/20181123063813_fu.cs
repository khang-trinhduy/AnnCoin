using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnConn.Migrations
{
    public partial class fu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "q4b",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "q4c",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "q4a",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "q4a",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "q4b",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "q4c",
                table: "Customers",
                nullable: false,
                defaultValue: false);
        }
    }
}
