using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Features.Languages;

namespace Vocab.Core.Features.Words.Dtos;
public record WordDto
{
    public required Guid Id { get; init; }
    public required Guid LanguageId { get; init; }
    public required string LanguageName { get; init; }
    public required string Text { get; init; }
}
