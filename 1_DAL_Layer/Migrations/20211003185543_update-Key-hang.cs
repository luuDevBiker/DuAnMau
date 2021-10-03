using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_Layer.Migrations
{
    public partial class updateKeyhang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hangs_NhanViens_NhanVienMa_NhanVien",
                table: "Hangs");

            migrationBuilder.DropIndex(
                name: "IX_Hangs_NhanVienMa_NhanVien",
                table: "Hangs");

            migrationBuilder.DropColumn(
                name: "NhanVienMa_NhanVien",
                table: "Hangs");

            migrationBuilder.AddColumn<string>(
                name: "Ma_NhanVien",
                table: "Hangs",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Hangs_Ma_NhanVien",
                table: "Hangs",
                column: "Ma_NhanVien");

            migrationBuilder.AddForeignKey(
                name: "FK_Hangs_NhanViens_Ma_NhanVien",
                table: "Hangs",
                column: "Ma_NhanVien",
                principalTable: "NhanViens",
                principalColumn: "Ma_NhanVien",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hangs_NhanViens_Ma_NhanVien",
                table: "Hangs");

            migrationBuilder.DropIndex(
                name: "IX_Hangs_Ma_NhanVien",
                table: "Hangs");

            migrationBuilder.DropColumn(
                name: "Ma_NhanVien",
                table: "Hangs");

            migrationBuilder.AddColumn<string>(
                name: "NhanVienMa_NhanVien",
                table: "Hangs",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hangs_NhanVienMa_NhanVien",
                table: "Hangs",
                column: "NhanVienMa_NhanVien");

            migrationBuilder.AddForeignKey(
                name: "FK_Hangs_NhanViens_NhanVienMa_NhanVien",
                table: "Hangs",
                column: "NhanVienMa_NhanVien",
                principalTable: "NhanViens",
                principalColumn: "Ma_NhanVien",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
