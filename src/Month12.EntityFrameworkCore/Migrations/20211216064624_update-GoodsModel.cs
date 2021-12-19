using Microsoft.EntityFrameworkCore.Migrations;

namespace Month12.Migrations
{
    public partial class updateGoodsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "GoodPrice",
                table: "GoodsModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "GoodPrice",
                table: "GoodsModel",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
