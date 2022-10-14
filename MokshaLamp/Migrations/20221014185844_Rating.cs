using Microsoft.EntityFrameworkCore.Migrations;

namespace MokshaLamp.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Lamp",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(20, 2)");

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Lamp",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Lamp");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Lamp",
                type: "decimal(20, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");
        }
    }
}
