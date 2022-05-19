using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alta.EFCore.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HeartbeatInitiates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranId = table.Column<string>(type: "varchar(25)", nullable: true),
                    TranDT = table.Column<string>(type: "varchar(20)", nullable: true),
                    WHId = table.Column<string>(type: "varchar(10)", nullable: true),
                    WCSId = table.Column<string>(type: "varchar(10)", nullable: true),
                    Text = table.Column<string>(type: "varchar(50)", nullable: true),
                    ResponseDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageReceived = table.Column<string>(type: "varchar(MAX)", nullable: true),
                    CreationDatetime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeartbeatInitiates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequestInitiates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranId = table.Column<string>(type: "varchar(25)", nullable: true),
                    TranDT = table.Column<string>(type: "varchar(20)", nullable: true),
                    WHId = table.Column<string>(type: "varchar(10)", nullable: true),
                    WCSId = table.Column<string>(type: "varchar(10)", nullable: true),
                    LODNum = table.Column<string>(type: "varchar(50)", nullable: true),
                    RequestContentsFlag = table.Column<string>(type: "varchar(50)", nullable: true),
                    RequestStolocFlag = table.Column<string>(type: "varchar(50)", nullable: true),
                    MessageSent = table.Column<string>(type: "varchar(MAX)", nullable: true),
                    ResponseDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageReceived = table.Column<string>(type: "varchar(MAX)", nullable: true),
                    HasConcluded = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreationDatetime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Noted = table.Column<bool>(type: "bit", nullable: false),
                    Line = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestInitiates", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeartbeatInitiates");

            migrationBuilder.DropTable(
                name: "RequestInitiates");
        }
    }
}
