using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Features.Words.Commands;

namespace Vocab.Core.Features.Words;
public static class WordExtensions
{
    public static Word ToEntity(this CreateWordCommand command)
    {
        return new Word
        {
            LanguageId = command.LanguageId,
            Text = command.Text
        };
    }

    public static void ApplyUpdate(this Word entity, UpdateWordCommand command)
    {
        entity.LanguageId = command.LanguageId;
        entity.Text = command.Text;
    }
}
