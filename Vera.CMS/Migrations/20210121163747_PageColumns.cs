using Microsoft.EntityFrameworkCore.Migrations;

namespace Vera.CMS.Migrations
{
    public partial class PageColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>("Header", "Page", "varchar", nullable: false);
            migrationBuilder.AddColumn<int>("Content", "Page", "jsonb", nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("Header", "Page");
            migrationBuilder.DropColumn("Content", "Page");
        }
    }
}
