using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_Layer.Migrations
{
    public partial class updatetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hangs_NhanViens_Ep_Code",
                table: "Hangs");

            migrationBuilder.DropForeignKey(
                name: "FK_KhachHangs_NhanViens_Ep_Code",
                table: "KhachHangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NhanViens",
                table: "NhanViens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHangs",
                table: "KhachHangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hangs",
                table: "Hangs");

            migrationBuilder.RenameTable(
                name: "NhanViens",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "KhachHangs",
                newName: "Customers");

            migrationBuilder.RenameTable(
                name: "Hangs",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_KhachHangs_Ep_Code",
                table: "Customers",
                newName: "IX_Customers_Ep_Code");

            migrationBuilder.RenameIndex(
                name: "IX_Hangs_Ep_Code",
                table: "Products",
                newName: "IX_Products_Ep_Code");

            migrationBuilder.AddColumn<byte[]>(
                name: "Img_Barcode",
                table: "Products",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<int>(
                name: "Prd_Sale",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Ep_Code");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Ct_PhoneNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Prd_Code");

            migrationBuilder.CreateTable(
                name: "Customer_Order",
                columns: table => new
                {
                    CO_Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total_Money = table.Column<int>(type: "int", nullable: false),
                    Ep_Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CustomerCt_PhoneNumber = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Order", x => x.CO_Code);
                    table.ForeignKey(
                        name: "FK_Customer_Order_Customers_CustomerCt_PhoneNumber",
                        column: x => x.CustomerCt_PhoneNumber,
                        principalTable: "Customers",
                        principalColumn: "Ct_PhoneNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Order_Employees_Ep_Code",
                        column: x => x.Ep_Code,
                        principalTable: "Employees",
                        principalColumn: "Ep_Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Order_CustomerCt_PhoneNumber",
                table: "Customer_Order",
                column: "CustomerCt_PhoneNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Order_Ep_Code",
                table: "Customer_Order",
                column: "Ep_Code");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Employees_Ep_Code",
                table: "Customers",
                column: "Ep_Code",
                principalTable: "Employees",
                principalColumn: "Ep_Code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Employees_Ep_Code",
                table: "Products",
                column: "Ep_Code",
                principalTable: "Employees",
                principalColumn: "Ep_Code",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Employees_Ep_Code",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Employees_Ep_Code",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Customer_Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Img_Barcode",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Prd_Sale",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Hangs");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "NhanViens");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "KhachHangs");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Ep_Code",
                table: "Hangs",
                newName: "IX_Hangs_Ep_Code");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_Ep_Code",
                table: "KhachHangs",
                newName: "IX_KhachHangs_Ep_Code");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hangs",
                table: "Hangs",
                column: "Prd_Code");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhanViens",
                table: "NhanViens",
                column: "Ep_Code");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhachHangs",
                table: "KhachHangs",
                column: "Ct_PhoneNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Hangs_NhanViens_Ep_Code",
                table: "Hangs",
                column: "Ep_Code",
                principalTable: "NhanViens",
                principalColumn: "Ep_Code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KhachHangs_NhanViens_Ep_Code",
                table: "KhachHangs",
                column: "Ep_Code",
                principalTable: "NhanViens",
                principalColumn: "Ep_Code",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
