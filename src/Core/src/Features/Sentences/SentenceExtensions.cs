using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Features.Sentences.Commands;

namespace Vocab.Core.Features.Sentences;
public static class SentenceExtensions
{
    public static Sentence ToEntity(this CreateSentenceCommand command)
    {
        return new Sentence
        {
            WordId = command.WordId,
            SentenceText = command.SentenceText
        };
    }
    public static void ApplyUpdate(this Sentence entity, UpdateSentenceCommand command)
    {
        entity.WordId = command.WordId;
        entity.SentenceText = command.SentenceText;
    }
}
