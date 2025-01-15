using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Features.Languages;
using Vocab.Core.Features.Words;

namespace Vocab.Core.Features.Sentences.Commands;
public record CreateSentenceCommand
{
    public required Guid WordId { get; init; }
    public required Guid LanguageId { get; init; }
    public required string SentenceText { get; init; }
}
