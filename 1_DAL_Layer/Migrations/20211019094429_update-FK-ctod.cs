using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_Layer.Migrations
{
    public partial class updateFKctod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Orders_Customers_CustomerCt_PhoneNumber",
                table: "Customer_Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Orders_Employees_Ep_Code",
                table: "Customer_Orders");

            migrationBuilder.DropIndex(
                name: "IX_Customer_Orders_CustomerCt_PhoneNumber",
                table: "Customer_Orders");

            migrationBuilder.DropIndex(
                name: "IX_Customer_Orders_Ep_Code",
                table: "Customer_Orders");

            migrationBuilder.DropColumn(
                name: "CustomerCt_PhoneNumber",
                table: "Customer_Orders");

            migrationBuilder.AddColumn<string>(
                name: "Ct_Code",
                table: "Customer_Orders",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Orders_Ct_Code",
                table: "Customer_Orders",
                column: "Ct_Code");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Orders_Customers_Ct_Code",
                table: "Customer_Orders",
                column: "Ct_Code",
                principalTable: "Customers",
                principalColumn: "Ct_PhoneNumber",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Orders_Customers_Ct_Code",
                table: "Customer_Orders");

            migrationBuilder.DropIndex(
                name: "IX_Customer_Orders_Ct_Code",
                table: "Customer_Orders");

            migrationBuilder.DropColumn(
                name: "Ct_Code",
                table: "Customer_Orders");

            migrationBuilder.AddColumn<string>(
                name: "CustomerCt_PhoneNumber",
                table: "Customer_Orders",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Orders_CustomerCt_PhoneNumber",
                table: "Customer_Orders",
                column: "CustomerCt_PhoneNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Orders_Ep_Code",
                table: "Customer_Orders",
                column: "Ep_Code");

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
    }
}
