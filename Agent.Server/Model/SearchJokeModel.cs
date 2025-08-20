namespace AI.Server.Joke.Model;

using Agent.Server.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents the result of a joke search, including the total number of jokes found and the list of joke results.
/// </summary>
public sealed class SearchJokeModel
{
    /// <summary>
    /// Gets or sets the total number of jokes found in the search.
    /// </summary>
    [JsonProperty("total")]
    public int Total { get; set; }

    /// <summary>
    /// Gets or sets the list of jokes returned by the search.
    /// </summary>
    [JsonProperty("result")]
    public List<JokeModel> Result { get; set; } = [];
}
