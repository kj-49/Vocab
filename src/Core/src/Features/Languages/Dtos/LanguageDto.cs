﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocab.Core.Features.Languages.Dtos;
public record LanguageDto
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
}
