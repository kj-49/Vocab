using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Features.Languages.Commands;

namespace Vocab.Core.Features.Languages;
public static class LanguageExtensions
{
    public static Language ToEntity(this CreateLanguageCommand command)
    {
        return new Language
        {
            Name = command.Name
        };
    }

    public static void ApplyUpdate(this Language entity, UpdateLanguageCommand command)
    {
        entity.Name = command.Name;
    }
}
