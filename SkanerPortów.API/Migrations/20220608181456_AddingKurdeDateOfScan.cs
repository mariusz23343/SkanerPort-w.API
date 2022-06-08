using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SkanerPortów.API.Migrations
{
    public partial class AddingKurdeDateOfScan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ScanDate",
                table: "ScanEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ScanDate",
                table: "ScanEntities");
        }
    }
}
