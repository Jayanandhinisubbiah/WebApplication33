using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    public partial class migr7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_OrderMaster_OrderMasterOrderId",
                table: "OrderDetail");

            migrationBuilder.AlterColumn<int>(
                name: "OrderMasterOrderId",
                table: "OrderDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_OrderMaster_OrderMasterOrderId",
                table: "OrderDetail",
                column: "OrderMasterOrderId",
                principalTable: "OrderMaster",
                principalColumn: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_OrderMaster_OrderMasterOrderId",
                table: "OrderDetail");

            migrationBuilder.AlterColumn<int>(
                name: "OrderMasterOrderId",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_OrderMaster_OrderMasterOrderId",
                table: "OrderDetail",
                column: "OrderMasterOrderId",
                principalTable: "OrderMaster",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
