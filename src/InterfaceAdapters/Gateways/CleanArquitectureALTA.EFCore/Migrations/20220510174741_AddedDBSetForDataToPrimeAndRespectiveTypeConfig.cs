using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alta.EFCore.Migrations
{
    public partial class AddedDBSetForDataToPrimeAndRespectiveTypeConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataToPrime",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranId = table.Column<string>(type: "varchar(25)", nullable: true),
                    Data = table.Column<string>(type: "varchar(MAX)", nullable: true),
                    Endpoint = table.Column<string>(type: "varchar(50)", nullable: true),
                    Application = table.Column<string>(type: "varchar(50)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataToPrime", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataToPrime");
        }
    }
}
