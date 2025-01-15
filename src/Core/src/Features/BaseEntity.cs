using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocab.Core.Features;
public class BaseEntity
{
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
}
