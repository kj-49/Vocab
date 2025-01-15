using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocab.Core.Features.Translations.Commands;
public record CreateTranslationCommand
{
    public required Guid WordId { get; init; }
    public required Guid TranslatedWordId { get; init; }
}
