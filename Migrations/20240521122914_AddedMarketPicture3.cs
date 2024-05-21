using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class AddedMarketPicture3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "c6e7e3ad-52fe-4bf8-a8f7-2a9129a5d388");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "9293bf6f-3c4e-4430-b2c2-a2e1aa35718d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23f90580-0b65-4b50-94a1-df55f87f6d66", "AQAAAAIAAYagAAAAEONZgpzlkm8kcK2d5VW6JGn6g+LfBDsiHFFnJqPjfDcSGxNItsj3ZqbddWFCvxJ4bQ==", "fe595764-4c10-48c9-94ef-f461598172b0" });
        }
    }
}
