using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vocab.Core.Migrations
{
    /// <inheritdoc />
    public partial class AddUserLanguageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "app_user_id",
                table: "languages",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "user_language",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    language_id = table.Column<Guid>(type: "uuid", nullable: false),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    date_modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_language", x => x.id);
                    table.ForeignKey(
                        name: "fk_user_language_asp_net_users_user_id",
                        column: x => x.user_id,
                        principalTable: "asp_net_users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_user_language_languages_language_id",
                        column: x => x.language_id,
                        principalTable: "languages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_languages_app_user_id",
                table: "languages",
                column: "app_user_id");

            migrationBuilder.CreateIndex(
                name: "ix_user_language_language_id",
                table: "user_language",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "ix_user_language_user_id_language_id",
                table: "user_language",
                columns: new[] { "user_id", "language_id" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "fk_languages_users_app_user_id",
                table: "languages",
                column: "app_user_id",
                principalTable: "asp_net_users",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_languages_users_app_user_id",
                table: "languages");

            migrationBuilder.DropTable(
                name: "user_language");

            migrationBuilder.DropIndex(
                name: "ix_languages_app_user_id",
                table: "languages");

            migrationBuilder.DropColumn(
                name: "app_user_id",
                table: "languages");
        }
    }
}
