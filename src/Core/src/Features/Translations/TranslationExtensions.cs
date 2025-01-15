using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Features.Translations.Commands;

namespace Vocab.Core.Features.Translations;
public static class TranslationExtensions
{
    public static Translation ToEntity(this CreateTranslationCommand command)
    {
        return new Translation
        {
            WordId = command.WordId,
            TranslatedWordId = command.TranslatedWordId
        };
    }

    public static void ApplyUpdate(this Translation entity, UpdateTranslationCommand command)
    {
        entity.WordId = command.WordId;
        entity.TranslatedWordId = command.TranslatedWordId;
    }
}
