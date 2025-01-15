using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Features.UserWordInfo;

namespace Vocab.Core.Features.UserWordInfos;
public class UserWordConfiguration : IEntityTypeConfiguration<UserWord>
{
    public void Configure(EntityTypeBuilder<UserWord> builder)
    {
        builder.HasKey(u => u.Id);

        builder.HasIndex(u => new { u.UserId, u.WordId })
            .IsUnique();

        builder.HasOne(u => u.User)
            .WithMany()
            .HasForeignKey(u => u.UserId);

        builder.HasOne(u => u.Word)
            .WithMany()
            .HasForeignKey(u => u.WordId);

        builder.HasOne(u => u.WordStrength)
            .WithMany()
            .HasForeignKey(u => u.WordStrengthId);
    }
}
