using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vocab.Core.Migrations
{
    /// <inheritdoc />
    public partial class RemoveLanguageFromSentence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_sentences_languages_language_id",
                table: "sentences");

            migrationBuilder.DropIndex(
                name: "ix_sentences_language_id",
                table: "sentences");

            migrationBuilder.DropColumn(
                name: "language_id",
                table: "sentences");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "language_id",
                table: "sentences",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "ix_sentences_language_id",
                table: "sentences",
                column: "language_id");

            migrationBuilder.AddForeignKey(
                name: "fk_sentences_languages_language_id",
                table: "sentences",
                column: "language_id",
                principalTable: "languages",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
