namespace AI.Server.Joke.Service;

using Agent.Server.Model;
using AI.Server.Joke.Model;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

/// <summary>
/// Provides methods for retrieving jokes, joke categories, and searching jokes from a remote API.
/// </summary>
public interface IJokeService
{
    /// <summary>
    /// Retrieves a random joke.
    /// </summary>
    /// <returns>A <see cref="JokeModel"/> representing a random joke.</returns>
    [Get("/jokes/random")]
    Task<JokeModel> GetRandomJokeAsync();

    /// <summary>
    /// Retrieves a list of available joke categories.
    /// </summary>
    /// <returns>A list of category names.</returns>
    [Get("/jokes/categories")]
    Task<List<string>> GetCategoriesAsync();

    /// <summary>
    /// Retrieves a random joke from a specified category.
    /// </summary>
    /// <param name="category">The category to filter jokes by.</param>
    /// <returns>A <see cref="JokeModel"/> representing a random joke from the specified category.</returns>
    [Get("/jokes/random?category={category}")]
    Task<JokeModel> GetJokeByCategoryAsync(string category);

    /// <summary>
    /// Searches for jokes that match the specified query.
    /// </summary>
    /// <param name="query">The search query string.</param>
    /// <returns>A <see cref="SearchJokeModel"/> containing the search results.</returns>
    [Get("/jokes/search?query={query}")]
    Task<SearchJokeModel> GetJokeBySearchAsync(string query);
}
