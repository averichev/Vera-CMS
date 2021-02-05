using System;
using System.IO;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vera.CMS.Migrations
{
    public partial class InAspNetUsersBoolDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sqlFile = Path.Combine(
                Environment.CurrentDirectory,
                "Migrations/SQL/PostgreSQL/20210122104748_InAspNetUsersBoolDefault.sql"
            );
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }
    }
}
