using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_Layer.Migrations
{
    public partial class fisrt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    Ma_NhanVien = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ID_NhanVien = table.Column<int>(type: "int", nullable: false),
                    TenNhanVien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VaiTro = table.Column<int>(type: "int", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    TrangThaiMatKhau = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.Ma_NhanVien);
                });

            migrationBuilder.CreateTable(
                name: "Hangs",
                columns: table => new
                {
                    MaHang = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ID_Hang = table.Column<int>(type: "int", nullable: false),
                    TenHang = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGiaNhap = table.Column<int>(type: "int", nullable: false),
                    DonGiaBan = table.Column<int>(type: "int", nullable: false),
                    AnhHang = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ma_NhanVien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhanVienMa_NhanVien = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hangs", x => x.MaHang);
                    table.ForeignKey(
                        name: "FK_Hangs_NhanViens_NhanVienMa_NhanVien",
                        column: x => x.NhanVienMa_NhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "Ma_NhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    SDT = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TenKhachHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    Ma_NanVienMa_NhanVien = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.SDT);
                    table.ForeignKey(
                        name: "FK_KhachHangs_NhanViens_Ma_NanVienMa_NhanVien",
                        column: x => x.Ma_NanVienMa_NhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "Ma_NhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hangs_NhanVienMa_NhanVien",
                table: "Hangs",
                column: "NhanVienMa_NhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHangs_Ma_NanVienMa_NhanVien",
                table: "KhachHangs",
                column: "Ma_NanVienMa_NhanVien");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hangs");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "NhanViens");
        }
    }
}
