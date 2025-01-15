using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocab.Core.Features.WordStrengths;
public class WordStrengthConfiguration : IEntityTypeConfiguration<WordStrength>
{
    public void Configure(EntityTypeBuilder<WordStrength> builder)
    {
        builder.HasKey(u => u.Id);
    }
}
