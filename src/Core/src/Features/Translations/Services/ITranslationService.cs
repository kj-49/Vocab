using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Features.Languages.Commands;
using Vocab.Core.Features.Languages.Dtos;
using Vocab.Core.Features.Translations.Commands;
using Vocab.Core.Features.Translations.Dtos;

namespace Vocab.Core.Features.Translations.Services;
public interface ITranslationService
{
    Task CreateAsync(CreateTranslationCommand command);
    Task UpdateAsync(UpdateTranslationCommand command);
    Task<TranslationDto> GetAsync(Guid id);
    Task<ICollection<TranslationDto>> GetAllAsync();
}
