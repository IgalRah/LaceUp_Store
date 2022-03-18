using Microsoft.EntityFrameworkCore.Migrations;

namespace LaceUp.Migrations
{
    public partial class UpdateShoeInfoModel3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShoeName",
                table: "ShoeInffo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShoeName",
                table: "ShoeInffo");
        }
    }
}
