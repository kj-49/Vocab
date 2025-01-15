using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocab.Core.Features.Sentences.Commands;
public record UpdateSentenceCommand
{
    public required Guid Id { get; init; }
    public required Guid WordId { get; init; }
    public required Guid LanguageId { get; init; }
    public required string SentenceText { get; init; }
}
