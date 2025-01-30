using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updatePermissionsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PermissionEntity",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "CreateSigma");

            migrationBuilder.UpdateData(
                table: "PermissionEntity",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "ReadSigma");

            migrationBuilder.UpdateData(
                table: "PermissionEntity",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "UpdateSigma");

            migrationBuilder.UpdateData(
                table: "PermissionEntity",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "DeleteSigma");

            migrationBuilder.InsertData(
                table: "PermissionEntity",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "CreateUser" },
                    { 6, "ReadUser" },
                    { 7, "UpdateUser" },
                    { 8, "DeleteUser" }
                });

            migrationBuilder.InsertData(
                table: "RolePermissionEntity",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 3, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Professor");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "User" });

            migrationBuilder.InsertData(
                table: "RolePermissionEntity",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 },
                    { 6, 2 },
                    { 2, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePermissionEntity",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "RolePermissionEntity",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "RolePermissionEntity",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "RolePermissionEntity",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "RolePermissionEntity",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "RolePermissionEntity",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "RolePermissionEntity",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "RolePermissionEntity",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "PermissionEntity",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PermissionEntity",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PermissionEntity",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PermissionEntity",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "PermissionEntity",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Create");

            migrationBuilder.UpdateData(
                table: "PermissionEntity",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Read");

            migrationBuilder.UpdateData(
                table: "PermissionEntity",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Update");

            migrationBuilder.UpdateData(
                table: "PermissionEntity",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Delete");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "User");
        }
    }
}
