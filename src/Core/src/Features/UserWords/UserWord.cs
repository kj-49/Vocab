using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Features.Identity.Users;
using Vocab.Core.Features.Words;
using Vocab.Core.Features.WordStrengths;

namespace Vocab.Core.Features.UserWordInfo;
public class UserWord : BaseEntity
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public AppUser User { get; set; }
    public Guid WordId { get; set; }
    public Word Word { get; set; }
    public Guid WordStrengthId { get; set; }
    public WordStrength WordStrength { get; set; }
    /// <summary>
    /// Word should be interpreted as "known" or "familiar" if this is true.
    /// </summary>
    public bool Buried { get; set; }
    public DateTime? LastSeen { get; set; }
}
