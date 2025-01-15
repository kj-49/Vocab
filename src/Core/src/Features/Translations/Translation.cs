using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Features.Words;

namespace Vocab.Core.Features.Translations;
public class Translation : BaseEntity
{
    public Guid Id { get; set; }
    public Guid WordId { get; set; }
    public Word Word { get; set; }
    public Guid TranslatedWordId { get; set; }
    public Word TranslatedWord { get; set; }
}
