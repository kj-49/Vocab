using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Features.Languages.Commands;
using Vocab.Core.Features.Languages.Dtos;

namespace Vocab.Core.Features.Languages.Services;
public interface ILanguageService
{
    Task CreateAsync(CreateLanguageCommand command);
    Task UpdateAsync(UpdateLanguageCommand command);
    Task<LanguageDto> GetAsync(Guid id);
    Task<ICollection<LanguageDto>> GetAllAsync();
}
