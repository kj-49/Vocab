using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vocab.Core.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "asp_net_roles",
                columns: new[] { "id", "concurrency_stamp", "name", "normalized_name" },
                values: new object[,]
                {
                    { new Guid("0fc9654a-1bec-4593-b0c6-0bb845630e1f"), null, "Admin", "ADMIN" },
                    { new Guid("5554c76e-542c-4994-907f-fde29f8e4fd9"), null, "Client", "CLIENT" },
                    { new Guid("c4dd2d51-dd9f-495a-bd22-670c0f77ec3e"), null, "Master", "MASTER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: new Guid("0fc9654a-1bec-4593-b0c6-0bb845630e1f"));

            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: new Guid("5554c76e-542c-4994-907f-fde29f8e4fd9"));

            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: new Guid("c4dd2d51-dd9f-495a-bd22-670c0f77ec3e"));
        }
    }
}
