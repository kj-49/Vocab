using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocab.Core.Features.Translations.Dtos;
public record TranslationDto
{
    public required Guid Id { get; init; }
    public required Guid WordId { get; init; }
    public required string WordText { get; init; }
    public required Guid TranslatedWordId { get; init; }
    public required string TranslatedWordText { get; init; }
}
