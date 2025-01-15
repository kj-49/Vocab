using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Features.Languages;
using Vocab.Core.Features.Words;

namespace Vocab.Core.Features.Sentences;
public class Sentence
{
    public Guid Id { get; set; }
    public Guid WordId { get; set; }
    public Word Word { get; set; }
    public Guid LanguageId { get; set; }
    public Language Language { get; set; }
    public string SentenceText { get; set; }
}
