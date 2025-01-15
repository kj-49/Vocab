using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Features.Languages.Commands;
using Vocab.Core.Features.Languages.Dtos;
using Vocab.Core.Features.Sentences.Commands;
using Vocab.Core.Features.Sentences.Dtos;

namespace Vocab.Core.Features.Sentences.Services;
public interface ISentenceService
{
    Task CreateAsync(CreateSentenceCommand command);
    Task UpdateAsync(UpdateSentenceCommand command);
    Task<SentenceDto> GetAsync(Guid id);
    Task<ICollection<SentenceDto>> GetAllAsync();
}
