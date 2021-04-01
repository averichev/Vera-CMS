using Microsoft.EntityFrameworkCore.Migrations;

namespace Vera.CMS.Migrations
{
    public partial class PageLastUpdateField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                "LastUpdateTime",
                "Page",
                "timestamp",
                nullable: true
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "Description",
                "Page"
                );
        }
    }
}