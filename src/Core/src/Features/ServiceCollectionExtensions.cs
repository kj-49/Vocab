using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Core.Features.Languages.Services;
using Vocab.Core.Features.Sentences.Services;
using Vocab.Core.Features.Translations.Services;
using Vocab.Core.Features.Words.Services;

namespace Vocab.Core.Features;
public static class ServiceCollectionExtensions
{
    public static void AddFeatureServices(this IServiceCollection services)
    {
        services.AddScoped<ILanguageService, LanguageService>();
        services.AddScoped<ISentenceService, SentenceService>();
        services.AddScoped<ITranslationService, TranslationService>();
        services.AddScoped<IWordService, WordService>();
    }   
}
