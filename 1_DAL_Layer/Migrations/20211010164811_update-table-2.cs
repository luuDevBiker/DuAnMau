using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_Layer.Migrations
{
    public partial class updatetable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Order_Customers_CustomerCt_PhoneNumber",
                table: "Customer_Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Order_Employees_Ep_Code",
                table: "Customer_Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer_Order",
                table: "Customer_Order");

            migrationBuilder.RenameTable(
                name: "Customer_Order",
                newName: "Customer_Orders");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_Order_Ep_Code",
                table: "Customer_Orders",
                newName: "IX_Customer_Orders_Ep_Code");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_Order_CustomerCt_PhoneNumber",
                table: "Customer_Orders",
                newName: "IX_Customer_Orders_CustomerCt_PhoneNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer_Orders",
                table: "Customer_Orders",
                column: "CO_Code");

            migrationBuilder.CreateTable(
                name: "Customer_Order_Details",
                columns: table => new
                {
                    CO_Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Prd_Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ExportPrice = table.Column<int>(type: "int", nullable: false),
                    Sale = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Order_Details", x => new { x.CO_Code, x.Prd_Code });
                    table.ForeignKey(
                        name: "FK_Customer_Order_Details_Customer_Orders_CO_Code",
                        column: x => x.CO_Code,
                        principalTable: "Customer_Orders",
                        principalColumn: "CO_Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customer_Order_Details_Products_Prd_Code",
                        column: x => x.Prd_Code,
                        principalTable: "Products",
                        principalColumn: "Prd_Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Order_Details_Prd_Code",
                table: "Customer_Order_Details",
                column: "Prd_Code");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Orders_Customers_CustomerCt_PhoneNumber",
                table: "Customer_Orders",
                column: "CustomerCt_PhoneNumber",
                principalTable: "Customers",
                principalColumn: "Ct_PhoneNumber",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Orders_Employees_Ep_Code",
                table: "Customer_Orders",
                column: "Ep_Code",
                principalTable: "Employees",
                principalColumn: "Ep_Code",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Orders_Customers_CustomerCt_PhoneNumber",
                table: "Customer_Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Orders_Employees_Ep_Code",
                table: "Customer_Orders");

            migrationBuilder.DropTable(
                name: "Customer_Order_Details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer_Orders",
                table: "Customer_Orders");

            migrationBuilder.RenameTable(
                name: "Customer_Orders",
                newName: "Customer_Order");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_Orders_Ep_Code",
                table: "Customer_Order",
                newName: "IX_Customer_Order_Ep_Code");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_Orders_CustomerCt_PhoneNumber",
                table: "Customer_Order",
                newName: "IX_Customer_Order_CustomerCt_PhoneNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer_Order",
                table: "Customer_Order",
                column: "CO_Code");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Order_Customers_CustomerCt_PhoneNumber",
                table: "Customer_Order",
                column: "CustomerCt_PhoneNumber",
                principalTable: "Customers",
                principalColumn: "Ct_PhoneNumber",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Order_Employees_Ep_Code",
                table: "Customer_Order",
                column: "Ep_Code",
                principalTable: "Employees",
                principalColumn: "Ep_Code",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
