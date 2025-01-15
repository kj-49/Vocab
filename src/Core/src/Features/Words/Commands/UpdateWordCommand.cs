using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocab.Core.Features.Words.Commands;
public record UpdateWordCommand
{
    public required Guid Id { get; init; }
    public required Guid LanguageId { get; init; }
    public required string Text { get; init; }
}
