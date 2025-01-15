using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocab.Core.Features.UserLanguages;
public class UserLanguageConfiguration : IEntityTypeConfiguration<UserLanguage>
{
    public void Configure(EntityTypeBuilder<UserLanguage> builder)
    {
        builder.HasKey(u => u.Id);

        builder.HasIndex(u => new { u.UserId, u.LanguageId })
            .IsUnique();

        builder.HasOne(u => u.User)
            .WithMany(u => u.UserLanguages)
            .HasForeignKey(u => u.UserId);

        builder.HasOne(u => u.Language)
            .WithMany()
            .HasForeignKey(u => u.LanguageId);
    }
}
