using Microsoft.EntityFrameworkCore.Migrations;

namespace Month12.Migrations
{
    public partial class updatetablegoodsmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Images",
                table: "GoodsModel",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Images",
                table: "GoodsModel");
        }
    }
}
