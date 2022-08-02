using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    public partial class migr3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_UserList_UserId",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Food_FoodId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_OrderMaster_OrderMasterOrderId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderMaster_UserList_UserId",
                table: "OrderMaster");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserList",
                table: "UserList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "UserList",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "OrderDetail");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrderMasterOrderId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_OrderMasterOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_FoodId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_FoodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_User_UserId",
                table: "Cart",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Food_FoodId",
                table: "OrderDetail",
                column: "FoodId",
                principalTable: "Food",
                principalColumn: "FoodId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_OrderMaster_OrderMasterOrderId",
                table: "OrderDetail",
                column: "OrderMasterOrderId",
                principalTable: "OrderMaster",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderMaster_User_UserId",
                table: "OrderMaster",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_User_UserId",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Food_FoodId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_OrderMaster_OrderMasterOrderId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderMaster_User_UserId",
                table: "OrderMaster");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "UserList");

            migrationBuilder.RenameTable(
                name: "OrderDetail",
                newName: "OrderDetails");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_OrderMasterOrderId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrderMasterOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_FoodId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_FoodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserList",
                table: "UserList",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_UserList_UserId",
                table: "Cart",
                column: "UserId",
                principalTable: "UserList",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Food_FoodId",
                table: "OrderDetails",
                column: "FoodId",
                principalTable: "Food",
                principalColumn: "FoodId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_OrderMaster_OrderMasterOrderId",
                table: "OrderDetails",
                column: "OrderMasterOrderId",
                principalTable: "OrderMaster",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderMaster_UserList_UserId",
                table: "OrderMaster",
                column: "UserId",
                principalTable: "UserList",
                principalColumn: "UserId");
        }
    }
}
