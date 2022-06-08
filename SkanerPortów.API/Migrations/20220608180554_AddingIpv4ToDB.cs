using Microsoft.EntityFrameworkCore.Migrations;

namespace SkanerPortów.API.Migrations
{
    public partial class AddingIpv4ToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ipv4",
                table: "ScanEntities",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ipv4",
                table: "ScanEntities");
        }
    }
}
