using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _06_ReferenceProjectInClass.Migrations
{
    public partial class SkillInArticles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Skill",
                table: "Articles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Skill",
                table: "Articles");
        }
    }
}
