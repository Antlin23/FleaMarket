using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class InitTestRemoteDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "a2f6a41b-0857-437e-a1b8-e7841c52d00f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "767b7869-e2f1-4f31-b872-dfb15c7388b4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54b4f4a7-7109-434e-85ad-1a866f509806", "AQAAAAIAAYagAAAAEKRTuZfJk9OH260YfyKQf7TlnRiiaw5SwwOcPEB9oQOUfTzwYIHh52qsOkzn7rXjtw==", "af7a14b2-c70f-4be9-b74a-62878975349c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "7960e094-fa94-4f1d-81b7-bb10c2ed8f07");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "ccc6346a-208e-4120-a45a-82c76daadabc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03eb0c6f-299e-4a1f-93d9-59fd760c6d06", "AQAAAAIAAYagAAAAEH0ncVRyuE9NcjXcpEO2TECg0buieUwojOYOwo/WRmL37Ofe/jqmzERkhmfIoXwanw==", "7b41ddff-12cc-49e6-a955-426037169509" });
        }
    }
}
