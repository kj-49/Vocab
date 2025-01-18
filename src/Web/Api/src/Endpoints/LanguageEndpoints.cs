using Vocab.Core.Features.Languages.Commands;
using Vocab.Core.Features.Languages.Dtos;
using Vocab.Core.Features.Languages.Services;

namespace Vocab.Web.Api.Endpoints;

public static class LanguageEndpoints
{
    public static void MapLanguageEndpoints(this WebApplication app)
    {
        app.MapPost("/api/languages", async (CreateLanguageCommand command, ILanguageService languageService) =>
        {
            await languageService.CreateAsync(command);
            return Results.Created($"/api/languages/{5}", command);
        })
        .WithName("CreateLanguage")
        .WithOpenApi();

        // Get all languages
        app.MapGet("/api/languages", async (ILanguageService languageService) =>
        {
            var languages = await languageService.GetAllAsync();

            languages = new List<LanguageDto> { new LanguageDto { Id = new Guid(), Name = "Test" } };

            return Results.Ok(languages);
        })
        .WithName("GetAllLanguages")
        .WithOpenApi();

        // Get a single language by id
        app.MapGet("/api/languages/{id}", async (Guid id, ILanguageService languageService) =>
        {
            try
            {
                var language = await languageService.GetAsync(id);
                return Results.Ok(language);
            }
            catch (Exception)
            {
                return Results.NotFound();
            }
        })
        .WithName("GetLanguageById")
        .WithOpenApi();


        // Update a language
        app.MapPut("/api/languages/{id}", async (Guid id, UpdateLanguageCommand command, ILanguageService languageService) =>
        {
            //command.Id = 5;  // Set the id for the update
            await languageService.UpdateAsync(command);
            return Results.NoContent();
        })
        .WithName("UpdateLanguage")
        .WithOpenApi();
    }
}
