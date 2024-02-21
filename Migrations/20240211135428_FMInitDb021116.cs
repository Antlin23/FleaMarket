using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class FMInitDb021116 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProducts");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Products",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "24c4d955-1152-43b1-95fe-f5bc6ffb1606");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "1a9e5ab7-b673-4d29-8dbb-d9ed7bfdd1a0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "080a3208-5dd5-41a2-b516-045770a60508", "AQAAAAIAAYagAAAAEAQHU5Vh+TYIArqzLKcbBBvpB+PUeRpKi1nnd9QL18jweTPozRD/5ZJDvsiIk9AHqw==", "e9796391-2da5-45bc-9447-f32405c08385" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_UserId",
                table: "Products",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_UserId",
                table: "Products",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_UserId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_UserId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "UserProducts",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProducts", x => new { x.UserId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_UserProducts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "99972bcd-da5e-49f1-a167-78af9210c6e6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "8ce1905b-4af8-4306-bb97-e10ceee8cadd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c678d071-a1f6-4454-b200-7829a7130745", "AQAAAAIAAYagAAAAEL2B+FzvipIK+LE/Hg4daG6/BuH7DCNfKddvV8bUSopE/pgSlFEmCb4zpFZYGLxkSw==", "8dd06b6f-68c0-4fdb-ba80-8dee2d7c4cdd" });

            migrationBuilder.CreateIndex(
                name: "IX_UserProducts_ProductId",
                table: "UserProducts",
                column: "ProductId");
        }
    }
}
