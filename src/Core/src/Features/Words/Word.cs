using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Features.Languages;

namespace Vocab.Core.Features.Words;
public class Word : BaseEntity
{
    public Guid Id { get; set; }
    public Guid LanguageId { get; set; }
    public Language Language { get; set; }
    public string Text { get; set; }
}
