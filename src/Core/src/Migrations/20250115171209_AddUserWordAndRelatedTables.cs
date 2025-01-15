using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vocab.Core.Migrations
{
    /// <inheritdoc />
    public partial class AddUserWordAndRelatedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "word_strengths",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    strength = table.Column<string>(type: "text", nullable: false),
                    level = table.Column<double>(type: "double precision", nullable: false),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    date_modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_word_strengths", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_words",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    word_id = table.Column<Guid>(type: "uuid", nullable: false),
                    word_strength_id = table.Column<Guid>(type: "uuid", nullable: false),
                    buried = table.Column<bool>(type: "boolean", nullable: false),
                    last_seen = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    date_modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_words", x => x.id);
                    table.ForeignKey(
                        name: "fk_user_words_users_user_id",
                        column: x => x.user_id,
                        principalTable: "asp_net_users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_user_words_word_strengths_word_strength_id",
                        column: x => x.word_strength_id,
                        principalTable: "word_strengths",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_user_words_words_word_id",
                        column: x => x.word_id,
                        principalTable: "words",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_user_words_user_id_word_id",
                table: "user_words",
                columns: new[] { "user_id", "word_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_user_words_word_id",
                table: "user_words",
                column: "word_id");

            migrationBuilder.CreateIndex(
                name: "ix_user_words_word_strength_id",
                table: "user_words",
                column: "word_strength_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_words");

            migrationBuilder.DropTable(
                name: "word_strengths");
        }
    }
}
