using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Features.Identity.Users;
using Vocab.Core.Features.Languages;

namespace Vocab.Core.Features.UserLanguages;
public class UserLanguage : BaseEntity
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public AppUser User { get; set; }
    public Guid LanguageId { get; set; }
    public Language Language { get; set; }
}
