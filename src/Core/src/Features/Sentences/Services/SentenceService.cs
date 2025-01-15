using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Data;
using Vocab.Core.Features.Sentences.Commands;
using Vocab.Core.Features.Sentences.Dtos;

namespace Vocab.Core.Features.Sentences.Services;
public class SentenceService : ISentenceService
{
    private readonly ApplicationDbContext _context;

    public SentenceService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(CreateSentenceCommand command)
    {
        var entity = command.ToEntity();

        await _context.AddAsync(entity);

        await _context.SaveChangesAsync();
    }

    public async Task<ICollection<SentenceDto>> GetAllAsync()
    {
        return await _context.Sentences
            .Select(s => new SentenceDto
            {
                Id = s.Id,
                WordId = s.WordId,
                WordText = s.Word.Text,
                LanguageId = s.Word.LanguageId,
                LanguageName = s.Word.Language.Name,
                SentenceText = s.SentenceText
            })
            .ToListAsync();
    }

    public async Task<SentenceDto> GetAsync(Guid id)
    {
        return await _context.Sentences
            .Select(s => new SentenceDto
            {
                Id = s.Id,
                WordId = s.WordId,
                WordText = s.Word.Text,
                LanguageId = s.Word.LanguageId,
                LanguageName = s.Word.Language.Name,
                SentenceText = s.SentenceText
            })
            .SingleAsync(u => u.Id == id);
    }

    public async Task UpdateAsync(UpdateSentenceCommand command)
    {
        var entity = await _context.Sentences.SingleAsync(u => u.Id == command.Id);

        entity.ApplyUpdate(command);

        await _context.SaveChangesAsync();
    }
}
