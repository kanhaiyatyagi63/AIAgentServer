// -------------------------------------------------------------------
// <copyright file="AppSetting.cs" company="Kanhaya Tyagi">
// Copyright 2025 kanhaiyatyagi63 All rights reserved.
// </copyright>
// -------------------------------------------------------------------

namespace Agent.Server;

/// <summary>
/// Represents application settings such as the current environment.
/// </summary>
public class AppSetting
{
    /// <summary>
    /// The section name in the configuration file for <see cref="AppSetting"/>.
    /// </summary>
    public const string Section = "AppSetting";

    /// <summary>
    /// Gets or sets the application environment (e.g., Development, Production).
    /// </summary>
    public string Environment { get; set; } = "Development";
}
