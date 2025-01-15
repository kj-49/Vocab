using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocab.Core.Features.Translations;
public class TranslationConfiguration : IEntityTypeConfiguration<Translation>
{
    public void Configure(EntityTypeBuilder<Translation> builder)
    {
        builder.HasKey(u => u.Id);

        builder.HasOne(u => u.Word)
            .WithMany()
            .HasForeignKey(u => u.WordId);

        builder.HasOne(u => u.TranslatedWord)
            .WithMany()
            .HasForeignKey(u => u.TranslatedWordId);
    }
}
