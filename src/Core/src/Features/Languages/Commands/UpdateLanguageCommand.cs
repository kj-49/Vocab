using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocab.Core.Features.Languages.Commands;
public record UpdateLanguageCommand
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
}
