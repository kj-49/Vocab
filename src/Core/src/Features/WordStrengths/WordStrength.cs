using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocab.Core.Features.WordStrengths;
public class WordStrength : BaseEntity
{
    public Guid Id { get; set; }
    public string Strength { get; set; }
    /// <summary>
    /// A larger value indicates and stronger level of understanding / familiarity with the word.
    /// </summary>
    public double Level { get; set; }
}
