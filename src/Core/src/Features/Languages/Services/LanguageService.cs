using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Data;
using Vocab.Core.Features.Languages.Commands;
using Vocab.Core.Features.Languages.Dtos;

namespace Vocab.Core.Features.Languages.Services;
public class LanguageService : ILanguageService
{
    private readonly ApplicationDbContext _context;

    public LanguageService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(CreateLanguageCommand command)
    {
        var entity = command.ToEntity();

        await _context.Languages.AddAsync(entity);

        await _context.SaveChangesAsync();
    }

    public async Task<ICollection<LanguageDto>> GetAllAsync()
    {
        return await _context.Languages
            .Select(l => new LanguageDto
            {
                Id = l.Id,
                Name = l.Name
            })
            .ToListAsync();
    }

    public async Task<LanguageDto> GetAsync(Guid id)
    {
        return await _context.Languages
            .Select(l => new LanguageDto
            {
                Id = l.Id,
                Name = l.Name
            })
            .SingleAsync(u => u.Id == id);
    }

    public async Task UpdateAsync(UpdateLanguageCommand command)
    {
        var entity = await _context.Languages.SingleAsync(u => u.Id == command.Id);

        entity.ApplyUpdate(command);

        await _context.SaveChangesAsync();
    }
}
