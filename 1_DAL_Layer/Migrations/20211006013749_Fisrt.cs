using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_Layer.Migrations
{
    public partial class Fisrt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    Ep_Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ep_Id = table.Column<int>(type: "int", nullable: false),
                    Ep_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ep_Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ep_Role = table.Column<int>(type: "int", nullable: false),
                    Ep_Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ep_Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ep_Status = table.Column<bool>(type: "bit", nullable: false),
                    Ep_StatusPassword = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.Ep_Code);
                });

            migrationBuilder.CreateTable(
                name: "Hangs",
                columns: table => new
                {
                    Prd_Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Prd_Id = table.Column<int>(type: "int", nullable: false),
                    Prd_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Prd_Quantity = table.Column<int>(type: "int", nullable: false),
                    Prd_ImportPrice = table.Column<int>(type: "int", nullable: false),
                    Prd_ExportPrice = table.Column<int>(type: "int", nullable: false),
                    Prd_Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Prd_Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ep_Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hangs", x => x.Prd_Code);
                    table.ForeignKey(
                        name: "FK_Hangs_NhanViens_Ep_Code",
                        column: x => x.Ep_Code,
                        principalTable: "NhanViens",
                        principalColumn: "Ep_Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    Ct_PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ct_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ct_Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ct_Sex = table.Column<int>(type: "int", nullable: false),
                    Ep_Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.Ct_PhoneNumber);
                    table.ForeignKey(
                        name: "FK_KhachHangs_NhanViens_Ep_Code",
                        column: x => x.Ep_Code,
                        principalTable: "NhanViens",
                        principalColumn: "Ep_Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hangs_Ep_Code",
                table: "Hangs",
                column: "Ep_Code");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHangs_Ep_Code",
                table: "KhachHangs",
                column: "Ep_Code");
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
