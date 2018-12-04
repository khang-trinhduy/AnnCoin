using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnConn.Migrations
{
    public partial class galaxy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.AlterColumn<int>(
                name: "CollaboratorsID",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "birthday",
                table: "Collaborators",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Collaborators",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cmnd",
                table: "Collaborators",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "day",
                table: "Collaborators",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "district",
                table: "Collaborators",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "field",
                table: "Collaborators",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "house",
                table: "Collaborators",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nation",
                table: "Collaborators",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "office_name",
                table: "Collaborators",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "place",
                table: "Collaborators",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "position",
                table: "Collaborators",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "town",
                table: "Collaborators",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "zip",
                table: "Collaborators",
                nullable: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appoinment_sale_SaleID",
                table: "appoinment");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Collaborators_CollaboratorsID",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_appoinment",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "birthday",
                table: "Collaborators");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Collaborators");

            migrationBuilder.DropColumn(
                name: "cmnd",
                table: "Collaborators");

            migrationBuilder.DropColumn(
                name: "day",
                table: "Collaborators");

            migrationBuilder.DropColumn(
                name: "district",
                table: "Collaborators");

            migrationBuilder.DropColumn(
                name: "field",
                table: "Collaborators");

            migrationBuilder.DropColumn(
                name: "house",
                table: "Collaborators");

            migrationBuilder.DropColumn(
                name: "nation",
                table: "Collaborators");

            migrationBuilder.DropColumn(
                name: "office_name",
                table: "Collaborators");

            migrationBuilder.DropColumn(
                name: "place",
                table: "Collaborators");

            migrationBuilder.DropColumn(
                name: "position",
                table: "Collaborators");

            migrationBuilder.DropColumn(
                name: "town",
                table: "Collaborators");

            migrationBuilder.DropColumn(
                name: "zip",
                table: "Collaborators");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "Cash",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "Cmnd",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "Confirm",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "DType",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "Deposit",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "HKTT",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "Job",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "Money",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "NCH1",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "NCH2",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "NCH21",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "NCH3",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "NMS",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "NS",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "NSH",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "NSHH",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "New",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "Official",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "OldContract",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "Place",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "Purpose",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "Requires",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "SaleDetails",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "WorkPlace",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "cTime",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "ph",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "pms",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "pns",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "psh",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "pshh",
                table: "appoinment");

            migrationBuilder.DropColumn(
                name: "supporter",
                table: "appoinment");

            migrationBuilder.RenameTable(
                name: "appoinment",
                newName: "Appoinment");

            migrationBuilder.RenameColumn(
                name: "dTime",
                table: "Appoinment",
                newName: "product");

            migrationBuilder.RenameIndex(
                name: "IX_appoinment_SaleID",
                table: "Appoinment",
                newName: "IX_Appoinment_SaleID");

            migrationBuilder.AlterColumn<int>(
                name: "CollaboratorsID",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appoinment",
                table: "Appoinment",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appoinment_sale_SaleID",
                table: "Appoinment",
                column: "SaleID",
                principalTable: "sale",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Collaborators_CollaboratorsID",
                table: "Customers",
                column: "CollaboratorsID",
                principalTable: "Collaborators",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
