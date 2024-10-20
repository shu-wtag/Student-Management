using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagement.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddGetAllStudentStoredProceedure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27bad7c1-02de-41b1-ab3c-911ca5b5240b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8fd0293-6334-4a50-8441-2c4090baac93");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d5bd6626-3897-4448-8479-8a359f711940", null, "User", "USER" },
                    { "ec380405-e30f-4af6-8eb4-fe2917ff0b32", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5bd6626-3897-4448-8479-8a359f711940");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec380405-e30f-4af6-8eb4-fe2917ff0b32");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "27bad7c1-02de-41b1-ab3c-911ca5b5240b", null, "User", "USER" },
                    { "b8fd0293-6334-4a50-8441-2c4090baac93", null, "Admin", "ADMIN" }
                });
        }
    }
}
