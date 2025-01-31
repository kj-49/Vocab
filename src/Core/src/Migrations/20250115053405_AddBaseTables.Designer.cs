﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Vocab.Core.Data;

#nullable disable

namespace Vocab.Core.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250115053405_AddBaseTables")]
    partial class AddBaseTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Vocab.Core.Features.Languages.Language", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_created");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_modified");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_languages");

                    b.ToTable("languages", (string)null);
                });

            modelBuilder.Entity("Vocab.Core.Features.Sentences.Sentence", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("LanguageId")
                        .HasColumnType("uuid")
                        .HasColumnName("language_id");

                    b.Property<string>("SentenceText")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("sentence_text");

                    b.Property<Guid>("WordId")
                        .HasColumnType("uuid")
                        .HasColumnName("word_id");

                    b.HasKey("Id")
                        .HasName("pk_sentences");

                    b.HasIndex("LanguageId")
                        .HasDatabaseName("ix_sentences_language_id");

                    b.HasIndex("WordId")
                        .HasDatabaseName("ix_sentences_word_id");

                    b.ToTable("sentences", (string)null);
                });

            modelBuilder.Entity("Vocab.Core.Features.Translations.Translation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_created");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_modified");

                    b.Property<Guid>("TranslatedWordId")
                        .HasColumnType("uuid")
                        .HasColumnName("translated_word_id");

                    b.Property<Guid>("WordId")
                        .HasColumnType("uuid")
                        .HasColumnName("word_id");

                    b.HasKey("Id")
                        .HasName("pk_translations");

                    b.HasIndex("TranslatedWordId")
                        .HasDatabaseName("ix_translations_translated_word_id");

                    b.HasIndex("WordId")
                        .HasDatabaseName("ix_translations_word_id");

                    b.ToTable("translations", (string)null);
                });

            modelBuilder.Entity("Vocab.Core.Features.Words.Word", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_created");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_modified");

                    b.Property<Guid>("LanguageId")
                        .HasColumnType("uuid")
                        .HasColumnName("language_id");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("text");

                    b.HasKey("Id")
                        .HasName("pk_words");

                    b.HasIndex("LanguageId")
                        .HasDatabaseName("ix_words_language_id");

                    b.ToTable("words", (string)null);
                });

            modelBuilder.Entity("Vocab.Core.Features.Sentences.Sentence", b =>
                {
                    b.HasOne("Vocab.Core.Features.Languages.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_sentences_languages_language_id");

                    b.HasOne("Vocab.Core.Features.Words.Word", "Word")
                        .WithMany()
                        .HasForeignKey("WordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_sentences_words_word_id");

                    b.Navigation("Language");

                    b.Navigation("Word");
                });

            modelBuilder.Entity("Vocab.Core.Features.Translations.Translation", b =>
                {
                    b.HasOne("Vocab.Core.Features.Words.Word", "TranslatedWord")
                        .WithMany()
                        .HasForeignKey("TranslatedWordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_translations_words_translated_word_id");

                    b.HasOne("Vocab.Core.Features.Words.Word", "Word")
                        .WithMany()
                        .HasForeignKey("WordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_translations_words_word_id");

                    b.Navigation("TranslatedWord");

                    b.Navigation("Word");
                });

            modelBuilder.Entity("Vocab.Core.Features.Words.Word", b =>
                {
                    b.HasOne("Vocab.Core.Features.Languages.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_words_languages_language_id");

                    b.Navigation("Language");
                });
#pragma warning restore 612, 618
        }
    }
}
