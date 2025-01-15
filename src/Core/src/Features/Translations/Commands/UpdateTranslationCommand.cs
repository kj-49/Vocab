using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocab.Core.Features.Translations.Commands;
public class UpdateTranslationCommand
{
    public required Guid Id { get; init; }
    public required Guid WordId { get; init; }
    public required Guid TranslatedWordId { get; init; }
}
