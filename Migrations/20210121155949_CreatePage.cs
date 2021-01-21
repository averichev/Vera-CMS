using Microsoft.EntityFrameworkCore.Migrations;

namespace Vera.CMS.Migrations
{
    public partial class CreatePage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Page",
                _ => new { },
                constraints: _ => { }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Page");
        }
    }
}