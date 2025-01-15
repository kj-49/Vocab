using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vocab.Core.Migrations
{
    /// <inheritdoc />
    public partial class ModifyOneToManysAndAddUserLanguage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_languages_users_app_user_id",
                table: "languages");

            migrationBuilder.DropForeignKey(
                name: "fk_user_language_asp_net_users_user_id",
                table: "user_language");

            migrationBuilder.DropIndex(
                name: "ix_languages_app_user_id",
                table: "languages");

            migrationBuilder.DropColumn(
                name: "app_user_id",
                table: "languages");

            migrationBuilder.AddForeignKey(
                name: "fk_user_language_users_user_id",
                table: "user_language",
                column: "user_id",
                principalTable: "asp_net_users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_user_language_users_user_id",
                table: "user_language");

            migrationBuilder.AddColumn<Guid>(
                name: "app_user_id",
                table: "languages",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_languages_app_user_id",
                table: "languages",
                column: "app_user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_languages_users_app_user_id",
                table: "languages",
                column: "app_user_id",
                principalTable: "asp_net_users",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_user_language_asp_net_users_user_id",
                table: "user_language",
                column: "user_id",
                principalTable: "asp_net_users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
