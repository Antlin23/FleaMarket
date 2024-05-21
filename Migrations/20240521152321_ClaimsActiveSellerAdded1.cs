using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class ClaimsActiveSellerAdded1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "7e810958-03fe-4e82-ad41-fd340d8eb113");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "27b91f62-2f9e-4090-9cba-6942c36d5814");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82d1c926-708d-415c-b337-c75a65a53fc2", "AQAAAAIAAYagAAAAEOnz5GLO9VGeKx/aNjkmSlRUJiCdz5zlK318HNXj1MUMkKASdxVD2AdDi2V3TDwj1w==", "828457ef-e1b8-4e67-a88c-8e5e8a979fba" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "1d4dfb83-61d9-4107-a2e7-c6586a31c549");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "d91e9a23-974b-4504-85cd-1a8efb576e1a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72080ee0-2a43-48fa-9969-1b49e049181c", "AQAAAAIAAYagAAAAECqD5MRbsIvwTc82HtObnKwYHrc1vN+mDWnk3tqNeGJPT9bgVuWS6TDOdHdcQehCqA==", "10be0d58-438e-4514-b52d-9b7a4454b42e" });
        }
    }
}
