using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocab.Core.Features.Sentences.Dtos;
public class SentenceDto
{
    public required Guid Id { get; init; }
    public required Guid WordId { get; init; }
    public required string WordText { get; set; }
    public required Guid LanguageId { get; init; }
    public required string LanguageName { get; set; }
    public required string SentenceText { get; init; }
}
