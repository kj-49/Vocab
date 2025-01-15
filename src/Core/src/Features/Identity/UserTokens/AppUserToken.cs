using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocab.Core.Features.Identity.UserTokens;
public class AppUserToken : IdentityUserToken<Guid>
{
}
