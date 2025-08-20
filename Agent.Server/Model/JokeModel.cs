// -------------------------------------------------------------------
// <copyright file="JokeModel.cs" company="Kanhaya Tyagi">
// Copyright 2025 kanhaiyatyagi63 All rights reserved.
// </copyright>
// -------------------------------------------------------------------

using Newtonsoft.Json;

namespace Agent.Server.Model;

/// <summary>
/// Represents a joke with associated metadata such as icon, id, url, value, categories, and timestamps.
/// </summary>
public class JokeModel
{
    /// <summary>
    /// Gets or sets the URL of the icon associated with the joke.
    /// </summary>
    [JsonProperty("icon_url")]
    public string IconUrl { get; set; } = null!;

    /// <summary>
    /// Gets or sets the unique identifier of the joke.
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; } = null!;

    /// <summary>
    /// Gets or sets the URL where the joke can be accessed.
    /// </summary>
    [JsonProperty("url")]
    public string Url { get; set; } = null!;

    /// <summary>
    /// Gets or sets the text content of the joke.
    /// </summary>
    [JsonProperty("value")]
    public string Value { get; set; } = null!;

    /// <summary>
    /// Gets or sets the list of categories associated with the joke.
    /// </summary>
    [JsonProperty("categories")]
    public List<string> Categories { get; set; } = [];

    /// <summary>
    /// Gets or sets the date and time when the joke was created.
    /// </summary>
    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the joke was last updated.
    /// </summary>
    [JsonProperty("updated_at")]
    public DateTime UpdatedAt { get; set; }
}