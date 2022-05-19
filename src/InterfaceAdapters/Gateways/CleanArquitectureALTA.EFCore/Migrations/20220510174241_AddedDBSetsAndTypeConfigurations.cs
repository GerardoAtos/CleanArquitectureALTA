using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alta.EFCore.Migrations
{
    public partial class AddedDBSetsAndTypeConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestInitiates",
                table: "RequestInitiates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HeartbeatInitiates",
                table: "HeartbeatInitiates");

            migrationBuilder.RenameTable(
                name: "RequestInitiates",
                newName: "RequestInitiate");

            migrationBuilder.RenameTable(
                name: "HeartbeatInitiates",
                newName: "HeartbeatInitiate");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestInitiate",
                table: "RequestInitiate",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HeartbeatInitiate",
                table: "HeartbeatInitiate",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "DataFromPrime",
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
                    table.PrimaryKey("PK_DataFromPrime", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataFromPrime");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestInitiate",
                table: "RequestInitiate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HeartbeatInitiate",
                table: "HeartbeatInitiate");

            migrationBuilder.RenameTable(
                name: "RequestInitiate",
                newName: "RequestInitiates");

            migrationBuilder.RenameTable(
                name: "HeartbeatInitiate",
                newName: "HeartbeatInitiates");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestInitiates",
                table: "RequestInitiates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HeartbeatInitiates",
                table: "HeartbeatInitiates",
                column: "Id");
        }
    }
}
