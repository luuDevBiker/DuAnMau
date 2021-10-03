using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_Layer.Migrations
{
    public partial class updateHangDonhangnhap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DơnGiaNhap",
                table: "Hangs",
                newName: "DonGiaNhap");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DonGiaNhap",
                table: "Hangs",
                newName: "DơnGiaNhap");
        }
    }
}
