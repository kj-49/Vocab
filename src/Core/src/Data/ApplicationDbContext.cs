using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Features.Languages;
using Vocab.Core.Features.Sentences;
using Vocab.Core.Features.Translations;
using Vocab.Core.Features.Words;

namespace Vocab.Core.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Language> Languages { get; set; }
    public DbSet<Sentence> Sentences { get; set; }
    public DbSet<Translation> Translations { get; set; }
    public DbSet<Word> Words { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
