namespace Agent.Server.Tools;

using AI.Server.Joke.Service;
using ModelContextProtocol.Server;
using System.ComponentModel;
using System.Threading.Tasks;

/// <summary>
/// Provides server tool methods for retrieving jokes, joke categories, and searching jokes via the <see cref="IJokeService"/>.
/// </summary>
[McpServerToolType]
internal class JokeTool(IJokeService jokeService)
{
    /// <summary>
    /// The joke service used to retrieve jokes and categories.
    /// </summary>
    private readonly IJokeService _jokeService = jokeService ?? throw new ArgumentNullException(nameof(jokeService));

    /// <summary>
    /// Retrieves a random joke.
    /// </summary>
    /// <returns>A string containing a random joke, or a fallback message if unavailable.</returns>
    [McpServerTool(Name = "random")]
    [Description("Crack a random joke.")]
    public async Task<string> GetRandomJoke()
    {
        var joke = await _jokeService.GetRandomJokeAsync().ConfigureAwait(false);
        return joke?.Value ?? "I am not in a mood to crack a joke!";
    }

    /// <summary>
    /// Retrieves a random joke from the specified category.
    /// </summary>
    /// <param name="category">The category to filter jokes by.</param>
    /// <returns>A string containing a joke from the specified category, or a fallback message if unavailable.</returns>
    [McpServerTool(Name = "GetJokeByCategory")]
    [Description("Get jokes based on categories.")]
    public async Task<string> GetJokeByCategory([Description("Categories")] string category)
    {
        if (string.IsNullOrWhiteSpace(category))
            throw new ArgumentException("Category must not be null or empty.", nameof(category));

        var joke = await _jokeService.GetJokeByCategoryAsync(category).ConfigureAwait(false);
        return joke?.Value ?? "I am not in a mood to crack a joke!";
    }

    /// <summary>
    /// Searches for jokes that match the specified search term.
    /// </summary>
    /// <param name="search">The search term to use for finding jokes.</param>
    /// <returns>A list of joke strings matching the search term.</returns>
    [McpServerTool(Name = "GetJokeBySearch")]
    [Description("Get jokes by search.")]
    public async Task<List<string>> GetJokeBySearch(string search)
    {
        if (string.IsNullOrWhiteSpace(search))
            throw new ArgumentException("Search term must not be null or empty.", nameof(search));

        var result = await _jokeService.GetJokeBySearchAsync(search).ConfigureAwait(false);
        return result?.Result?.Select(x => x.Value).Where(v => !string.IsNullOrWhiteSpace(v)).ToList() ?? [];
    }

    /// <summary>
    /// Retrieves the list of available joke categories.
    /// </summary>
    /// <returns>A list of category names.</returns>
    [McpServerTool(Name = "GetCategories")]
    [Description("Get list of categories.")]
    public async Task<List<string>> GetCategories()
    {
        var categories = await _jokeService.GetCategoriesAsync().ConfigureAwait(false);
        return categories ?? [];
    }
}