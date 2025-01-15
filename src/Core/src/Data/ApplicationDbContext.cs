using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Features.Identity.RoleClaims;
using Vocab.Core.Features.Identity.Roles;
using Vocab.Core.Features.Identity.UserClaims;
using Vocab.Core.Features.Identity.UserLogins;
using Vocab.Core.Features.Identity.UserRoles;
using Vocab.Core.Features.Identity.Users;
using Vocab.Core.Features.Identity.UserTokens;
using Vocab.Core.Features.Languages;
using Vocab.Core.Features.Sentences;
using Vocab.Core.Features.Translations;
using Vocab.Core.Features.UserWordInfo;
using Vocab.Core.Features.Words;
using Vocab.Core.Features.WordStrengths;

namespace Vocab.Core.Data;
public class ApplicationDbContext 
    : IdentityDbContext<AppUser, AppRole, Guid, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Language> Languages { get; set; }
    public DbSet<Sentence> Sentences { get; set; }
    public DbSet<Translation> Translations { get; set; }
    public DbSet<Word> Words { get; set; }
    public DbSet<WordStrength> WordStrengths { get; set; }
    public DbSet<UserWord> UserWords { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
