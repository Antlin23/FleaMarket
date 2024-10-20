using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class Newdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "81703289-42e6-40a9-8d25-13a0e7c990d4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "1a778cf8-7567-4752-81c5-038bcbcbbaa1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a942cc9c-f0f9-4acc-862a-f6206ae08786", "AQAAAAIAAYagAAAAEN6HRBD6NlmYZyaIUF7HUDIoigu/6uHDfpnjyc1ZpwKr+3AilQ1Em1GEuYx4f4rJmQ==", "08e01620-9433-48aa-9d04-c0b9a7b90216" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "3cec734a-f8ea-45b3-a455-c259709f1e3b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "1c66d40d-1d4e-4700-a2d2-720717128d9b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd2d99e6-5657-4ae4-9e3e-280a8c6525ff", "AQAAAAIAAYagAAAAEHwW0yFGgIRMOcCK9rdzCKz0QNgprfwwRIw+3Tr75BG8/dKtol81u65yLdu3BtYOhQ==", "8971c03b-30a8-408c-b54a-7737ccd0ed8f" });
        }
    }
}
