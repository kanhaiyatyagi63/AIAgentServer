// -------------------------------------------------------------------
// <copyright file="SettingTool.cs" company="Kanhaya Tyagi">
// Copyright 2025 kanhaiyatyagi63 All rights reserved.
// </copyright>
// -------------------------------------------------------------------

namespace Agent.Server.Tools;

using Microsoft.Extensions.Options;
using ModelContextProtocol.Server;
using System.ComponentModel;

[McpServerToolType]
internal class SettingTool(IOptions<AppSetting> appSetting)
{
    private readonly AppSetting _appSetting = appSetting.Value;

    /// <summary>
    /// Gets the current environment setting.
    /// </summary>
    /// <returns>The current environment as a string.</returns>
    [McpServerTool]
    [Description("Gets the current environment setting.")]
    public string? GetCurrentEnvironment()
    {
        return _appSetting.Environment;
    }
}
