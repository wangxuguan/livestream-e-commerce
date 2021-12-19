using Microsoft.EntityFrameworkCore.Migrations;

namespace Month12.Migrations
{
    public partial class updatemenumodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "MenuModel",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "MenuModel");
        }
    }
}
