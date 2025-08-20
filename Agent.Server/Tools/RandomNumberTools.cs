// -------------------------------------------------------------------
// <copyright file="RandomNumberTools.cs" company="Kanhaya Tyagi">
// Copyright 2025 kanhaiyatyagi63 All rights reserved.
// </copyright>
// -------------------------------------------------------------------

using System.ComponentModel;
using System.Diagnostics;
using ModelContextProtocol.Server;

/// <summary>
/// Sample MCP tools for demonstration purposes.
/// These tools can be invoked by MCP clients to perform various operations.
/// </summary>
[McpServerToolType]
internal class RandomNumberTools
{
    /// <summary>
    /// Generates a random number between the specified minimum (inclusive) and maximum (exclusive) values.
    /// </summary>
    /// <param name="min">Minimum value (inclusive).</param>
    /// <param name="max">Maximum value (exclusive).</param>
    /// <returns>A random integer between <paramref name="min"/> (inclusive) and <paramref name="max"/> (exclusive).</returns>
    [McpServerTool]
    [Description("Generates a random number between the specified minimum and maximum values.")]
    public static int GetRandomNumber(
        [Description("Minimum value (inclusive)")] int min = 0,
        [Description("Maximum value (exclusive)")] int max = 100)
    {
        Debugger.Launch();
        return Random.Shared.Next(min, max);
    }
}
