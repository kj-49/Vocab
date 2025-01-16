using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Features.Identity.Users;

namespace Vocab.Core.Communication.Services;
public class EmailSender : IEmailSender<AppUser>
{
    public async Task SendConfirmationLinkAsync(AppUser user, string email, string confirmationLink)
    {
        return;
    }

    public async Task SendPasswordResetCodeAsync(AppUser user, string email, string resetCode)
    {
        return;
    }

    public async Task SendPasswordResetLinkAsync(AppUser user, string email, string resetLink)
    {
        return;
    }
}
