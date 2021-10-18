using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_Layer.Migrations
{
    public partial class updateIdctOd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Customer_Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Customer_Orders");
        }
    }
}
