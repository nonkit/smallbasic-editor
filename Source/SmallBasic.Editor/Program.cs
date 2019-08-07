﻿// <copyright file="Program.cs" company="MIT License">
// Licensed under the MIT License. See LICENSE file in the project root for license information.
// </copyright>

namespace SmallBasic.Editor
{
    using System.Globalization;
    using Microsoft.AspNetCore.Blazor.Builder;
    using Microsoft.AspNetCore.Blazor.Hosting;
    using Microsoft.Extensions.DependencyInjection;
    using SmallBasic.Editor.Components.Layout;

    public static class Program
    {
        public static void Main()
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            BlazorWebAssemblyHost
                .CreateDefaultBuilder()
                .UseBlazorStartup<Startup>()
                .Build()
                .Run();
        }
    }

    public class Startup
    {
#pragma warning disable CA1801, CA1822
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
#pragma warning restore CA1801, CA1822
    }
}
