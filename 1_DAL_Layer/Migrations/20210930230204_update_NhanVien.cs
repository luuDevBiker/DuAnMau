using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_Layer.Migrations
{
    public partial class update_NhanVien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TrangThai",
                table: "NhanViens",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "NhanViens");
        }
    }
}
