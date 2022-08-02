using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    public partial class migr4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_User_UserId",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderMaster_User_UserId",
                table: "OrderMaster");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "UserList");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserList",
                table: "UserList",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_UserList_UserId",
                table: "Cart",
                column: "UserId",
                principalTable: "UserList",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderMaster_UserList_UserId",
                table: "OrderMaster",
                column: "UserId",
                principalTable: "UserList",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_UserList_UserId",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderMaster_UserList_UserId",
                table: "OrderMaster");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserList",
                table: "UserList");

            migrationBuilder.RenameTable(
                name: "UserList",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_User_UserId",
                table: "Cart",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderMaster_User_UserId",
                table: "OrderMaster",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId");
        }
    }
}
