using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocab.Core.Features.Languages.Commands;
public record CreateLanguageCommand
{
    public required string Name { get; init; }
}
