using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Data;
using Vocab.Core.Features.Translations.Commands;
using Vocab.Core.Features.Translations.Dtos;

namespace Vocab.Core.Features.Translations.Services;
public class TranslationService : ITranslationService
{
    private readonly ApplicationDbContext _context;

    public TranslationService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(CreateTranslationCommand command)
    {
        var entity = command.ToEntity();

        await _context.Translations.AddAsync(entity);

        await _context.SaveChangesAsync();
    }

    public async Task<ICollection<TranslationDto>> GetAllAsync()
    {
        return await _context.Translations
            .Select(t => new TranslationDto
            {
                Id = t.Id,
                WordId = t.WordId,
                WordText = t.Word.Text,
                TranslatedWordId = t.TranslatedWordId,
                TranslatedWordText = t.TranslatedWord.Text
            })
            .ToListAsync();
    }

    public async Task<TranslationDto> GetAsync(Guid id)
    {
        return await _context.Translations
            .Select(t => new TranslationDto
            {
                Id = t.Id,
                WordId = t.WordId,
                WordText = t.Word.Text,
                TranslatedWordId = t.TranslatedWordId,
                TranslatedWordText = t.TranslatedWord.Text
            })
            .SingleAsync(u => u.Id == id);
    }

    public async Task UpdateAsync(UpdateTranslationCommand command)
    {
        var entity = await _context.Translations.SingleAsync(u => u.Id == command.Id);

        entity.ApplyUpdate(command);

        await _context.SaveChangesAsync();
    }
}
