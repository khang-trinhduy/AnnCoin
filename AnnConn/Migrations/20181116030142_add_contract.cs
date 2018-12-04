using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnConn.Migrations
{
    public partial class add_contract : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Contracts",
                newName: "s3");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "pDate",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "c1",
                table: "Contracts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "c2",
                table: "Contracts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "c3",
                table: "Contracts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "Contracts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "collabor",
                table: "Contracts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "condition",
                table: "Contracts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "customer",
                table: "Contracts",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "d1",
                table: "Contracts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "d2",
                table: "Contracts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "d3",
                table: "Contracts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "day1",
                table: "Contracts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "day2",
                table: "Contracts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "day3",
                table: "Contracts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "dl1",
                table: "Contracts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "dl2",
                table: "Contracts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "dl3",
                table: "Contracts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Contracts",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "f1",
                table: "Contracts",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "f2",
                table: "Contracts",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "f3",
                table: "Contracts",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "note",
                table: "Contracts",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "pDate",
                table: "Contracts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "Contracts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "r1",
                table: "Contracts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "r2",
                table: "Contracts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "r3",
                table: "Contracts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "s1",
                table: "Contracts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "s2",
                table: "Contracts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "c1",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "c2",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "c3",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "code",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "collabor",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "condition",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "customer",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "d1",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "d2",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "d3",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "day1",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "day2",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "day3",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "dl1",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "dl2",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "dl3",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "f1",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "f2",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "f3",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "note",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "pDate",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "r1",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "r2",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "r3",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "s1",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "s2",
                table: "Contracts");

            migrationBuilder.RenameColumn(
                name: "s3",
                table: "Contracts",
                newName: "MyProperty");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
