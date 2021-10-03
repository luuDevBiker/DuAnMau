using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_Layer.Migrations
{
    public partial class updateKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ma_NhanVien",
                table: "Hangs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ma_NhanVien",
                table: "Hangs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
