using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleaMarket.Migrations
{
    /// <inheritdoc />
    public partial class Removedunenessesaryclaims : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                column: "ConcurrencyStamp",
                value: "40d0c233-3323-4847-b669-db4788bf0add");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                column: "ConcurrencyStamp",
                value: "afa5ceec-f6f5-4a29-8551-5981685cc935");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0714b-7e95-47ff-9b50-460f04f29426",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dd418c5-0936-4107-9f7d-49993eba7c0a", "AQAAAAIAAYagAAAAEPb8SEaa5A9TEM7cHMewzNVFJcTAXi8QD9b84lwt3ONfCxDaPcuDa9t4SciDUcKZWw==", "f1c494ab-bb49-4fb3-807f-d5954b84bbb7" });
        }
    }
}
