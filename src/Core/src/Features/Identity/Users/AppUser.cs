using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Features.Words;

namespace Vocab.Core.Features.Identity.Users;
public class AppUser : IdentityUser<Guid>
{
    public ICollection<Word> Words { get; set; }
}
