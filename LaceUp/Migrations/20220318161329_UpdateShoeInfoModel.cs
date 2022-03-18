using Microsoft.EntityFrameworkCore.Migrations;

namespace LaceUp.Migrations
{
    public partial class UpdateShoeInfoModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShoeColor",
                table: "ShoeInffo",
                newName: "ShoePrice");

            migrationBuilder.AlterColumn<string>(
                name: "ShoeSize",
                table: "ShoeInffo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ShoeCategory",
                table: "ShoeInffo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShoeCategory",
                table: "ShoeInffo");

            migrationBuilder.RenameColumn(
                name: "ShoePrice",
                table: "ShoeInffo",
                newName: "ShoeColor");

            migrationBuilder.AlterColumn<int>(
                name: "ShoeSize",
                table: "ShoeInffo",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
