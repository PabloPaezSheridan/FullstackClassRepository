using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _06_ReferenceProjectInClass.Migrations
{
    public partial class StateInArticles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Articles",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Articles");
        }
    }
}
