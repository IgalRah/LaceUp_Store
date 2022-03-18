using Microsoft.EntityFrameworkCore.Migrations;

namespace LaceUp.Migrations
{
    public partial class UpdateShoeInfoModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShoeSize",
                table: "ShoeInffo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShoeSize",
                table: "ShoeInffo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
