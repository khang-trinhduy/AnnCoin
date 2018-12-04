using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnConn.Migrations
{
    public partial class ff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "q4",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "q6m",
                table: "Customers",
                newName: "q7m");

            migrationBuilder.RenameColumn(
                name: "q6l",
                table: "Customers",
                newName: "q7l");

            migrationBuilder.RenameColumn(
                name: "q6k",
                table: "Customers",
                newName: "q7k");

            migrationBuilder.RenameColumn(
                name: "q6j",
                table: "Customers",
                newName: "q7j");

            migrationBuilder.RenameColumn(
                name: "q6i",
                table: "Customers",
                newName: "q7i");

            migrationBuilder.RenameColumn(
                name: "q6h",
                table: "Customers",
                newName: "q7h");

            migrationBuilder.RenameColumn(
                name: "q6g",
                table: "Customers",
                newName: "q7g");

            migrationBuilder.RenameColumn(
                name: "q6f",
                table: "Customers",
                newName: "q7f");

            migrationBuilder.RenameColumn(
                name: "q6e",
                table: "Customers",
                newName: "q7e");

            migrationBuilder.RenameColumn(
                name: "q6d",
                table: "Customers",
                newName: "q7d");

            migrationBuilder.RenameColumn(
                name: "q5j",
                table: "Customers",
                newName: "q7c");

            migrationBuilder.RenameColumn(
                name: "q5i",
                table: "Customers",
                newName: "q7b");

            migrationBuilder.RenameColumn(
                name: "q5h",
                table: "Customers",
                newName: "q7a");

            migrationBuilder.RenameColumn(
                name: "q5g",
                table: "Customers",
                newName: "q4c");

            migrationBuilder.RenameColumn(
                name: "q5f",
                table: "Customers",
                newName: "q4b");

            migrationBuilder.RenameColumn(
                name: "q5e",
                table: "Customers",
                newName: "q4a");

            //migrationBuilder.CreateTable(
            //    name: "sale",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        name = table.Column<string>(nullable: false),
            //        phone = table.Column<string>(nullable: false),
            //        email = table.Column<string>(nullable: false),
            //        pass = table.Column<string>(nullable: false),
            //        info = table.Column<string>(nullable: true),
            //        display = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_sale", x => x.ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Appoinment",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Customer = table.Column<string>(nullable: false),
            //        sale = table.Column<string>(nullable: true),
            //        password = table.Column<string>(nullable: false),
            //        Contract = table.Column<int>(nullable: false),
            //        product = table.Column<string>(nullable: true),
            //        SaleID = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Appoinment", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK_Appoinment_sale_SaleID",
            //            column: x => x.SaleID,
            //            principalTable: "sale",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Appoinment_SaleID",
            //    table: "Appoinment",
            //    column: "SaleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appoinment");

            migrationBuilder.DropTable(
                name: "sale");

            migrationBuilder.RenameColumn(
                name: "q7m",
                table: "Customers",
                newName: "q6m");

            migrationBuilder.RenameColumn(
                name: "q7l",
                table: "Customers",
                newName: "q6l");

            migrationBuilder.RenameColumn(
                name: "q7k",
                table: "Customers",
                newName: "q6k");

            migrationBuilder.RenameColumn(
                name: "q7j",
                table: "Customers",
                newName: "q6j");

            migrationBuilder.RenameColumn(
                name: "q7i",
                table: "Customers",
                newName: "q6i");

            migrationBuilder.RenameColumn(
                name: "q7h",
                table: "Customers",
                newName: "q6h");

            migrationBuilder.RenameColumn(
                name: "q7g",
                table: "Customers",
                newName: "q6g");

            migrationBuilder.RenameColumn(
                name: "q7f",
                table: "Customers",
                newName: "q6f");

            migrationBuilder.RenameColumn(
                name: "q7e",
                table: "Customers",
                newName: "q6e");

            migrationBuilder.RenameColumn(
                name: "q7d",
                table: "Customers",
                newName: "q6d");

            migrationBuilder.RenameColumn(
                name: "q7c",
                table: "Customers",
                newName: "q5j");

            migrationBuilder.RenameColumn(
                name: "q7b",
                table: "Customers",
                newName: "q5i");

            migrationBuilder.RenameColumn(
                name: "q7a",
                table: "Customers",
                newName: "q5h");

            migrationBuilder.RenameColumn(
                name: "q4c",
                table: "Customers",
                newName: "q5g");

            migrationBuilder.RenameColumn(
                name: "q4b",
                table: "Customers",
                newName: "q5f");

            migrationBuilder.RenameColumn(
                name: "q4a",
                table: "Customers",
                newName: "q5e");

            migrationBuilder.AddColumn<bool>(
                name: "q4",
                table: "Customers",
                nullable: false,
                defaultValue: false);
        }
    }
}
