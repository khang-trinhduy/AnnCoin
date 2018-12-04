using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnConn.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Collaborators",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(nullable: true),
                    fullName = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    MyProperty = table.Column<string>(nullable: true),
                    office = table.Column<string>(nullable: true),
                    joinDate = table.Column<DateTime>(nullable: false),
                    gender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collaborators", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MyProperty = table.Column<string>(nullable: true),
                    CollaboratorsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contracts_Collaborators_CollaboratorsID",
                        column: x => x.CollaboratorsID,
                        principalTable: "Collaborators",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    note = table.Column<string>(nullable: true),
                    condition = table.Column<string>(nullable: true),
                    cNumber = table.Column<int>(nullable: false),
                    pNumber = table.Column<int>(nullable: false),
                    ch = table.Column<string>(nullable: true),
                    price = table.Column<double>(nullable: false),
                    policy = table.Column<string>(nullable: true),
                    charges = table.Column<double>(nullable: false),
                    totals = table.Column<double>(nullable: false),
                    CollaboratorsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Customers_Collaborators_CollaboratorsID",
                        column: x => x.CollaboratorsID,
                        principalTable: "Collaborators",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_CollaboratorsID",
                table: "Contracts",
                column: "CollaboratorsID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CollaboratorsID",
                table: "Customers",
                column: "CollaboratorsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Collaborators");
        }
    }
}
