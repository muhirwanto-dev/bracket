﻿using Bracket.Wasm.ViewModel;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

namespace Bracket.Wasm
{
    public static class ProgramExtensions
    {
        public static WebAssemblyHostBuilder RegisterServices(this WebAssemblyHostBuilder builder)
        {
            builder.Services.AddMudLocalization();
            builder.Services.AddMudPopoverService();
            builder.Services.AddMudBlazorDialog();
            builder.Services.AddMudServices();

            builder.Services.AddTransient<HomeViewModel>();

            return builder;
        }

        public static WebAssemblyHostBuilder RegisterHttpClient(this WebAssemblyHostBuilder builder)
        {
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            return builder;
        }
    }
}
