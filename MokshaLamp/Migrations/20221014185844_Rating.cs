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

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Lamp",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Lamp",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "string");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Lamp",
                type: "string",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "int");

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
