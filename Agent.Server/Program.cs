// -------------------------------------------------------------------
// <copyright file="Program.cs" company="Kanhaya Tyagi">
// Copyright 2025 kanhaiyatyagi63 All rights reserved.
// </copyright>
// -------------------------------------------------------------------

using Agent.Server;
using Agent.Server.Tools;
using AI.Server.Joke.Service;
using Refit;

var builder = Host.CreateApplicationBuilder(args);

builder.Logging.AddConsole(o => o.LogToStandardErrorThreshold = LogLevel.Trace);

builder.Services.Configure<AppSetting>(builder.Configuration.GetSection(AppSetting.Section));

builder.Services
    .AddMcpServer()
    .WithStdioServerTransport()
    .WithTools<JokeTool>()
    .WithTools<SettingTool>()
    .WithTools<RandomNumberTools>();

builder.Services
    .AddRefitClient<IJokeService>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://api.chucknorris.io"));
await builder.Build().RunAsync();
