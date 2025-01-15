using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Data;
using Vocab.Core.Features.Languages.Commands;
using Vocab.Core.Features.Words.Commands;
using Vocab.Core.Features.Words.Dtos;

namespace Vocab.Core.Features.Words.Services;
public class WordService : IWordService
{
    private readonly ApplicationDbContext _context;

    public WordService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(CreateWordCommand command)
    {
        var entity = command.ToEntity();

        await _context.Words.AddAsync(entity);

        await _context.SaveChangesAsync();
    }

    public async Task<ICollection<WordDto>> GetAllAsync()
    {
        return await _context.Words
            .Select(w => new WordDto
            {
                Id = w.Id,
                Text = w.Text,
                LanguageId = w.LanguageId,
                LanguageName = w.Language.Name
            })
            .ToListAsync();
    }

    public async Task<WordDto> GetAsync(Guid id)
    {
        return await _context.Words
            .Select(w => new WordDto
            {
                Id = w.Id,
                Text = w.Text,
                LanguageId = w.LanguageId,
                LanguageName = w.Language.Name
            })
            .SingleAsync(u => u.Id == id);
    }

    public async Task UpdateAsync(UpdateWordCommand command)
    {
        var entity = await _context.Words.SingleAsync(u => u.Id == command.Id);

        entity.ApplyUpdate(command);

        await _context.SaveChangesAsync();
    }
}
