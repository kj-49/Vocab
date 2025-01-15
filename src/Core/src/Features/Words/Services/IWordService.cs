using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Features.Languages.Commands;
using Vocab.Core.Features.Languages.Dtos;
using Vocab.Core.Features.Words.Commands;
using Vocab.Core.Features.Words.Dtos;

namespace Vocab.Core.Features.Words.Services;
public interface IWordService
{
    Task CreateAsync(CreateWordCommand command);
    Task UpdateAsync(UpdateWordCommand command);
    Task<WordDto> GetAsync(Guid id);
    Task<ICollection<WordDto>> GetAllAsync();
}
