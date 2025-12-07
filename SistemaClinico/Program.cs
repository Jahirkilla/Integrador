using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using SistemaClinico.Auth;
using SistemaClinico.Services;

namespace SistemaClinico
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            #region Radzen
            builder.Services.AddRadzenComponents();
            builder.Services.AddRadzenCookieThemeService(options =>
            {
                options.Name = "DwiTheme";
                options.Duration = TimeSpan.FromDays(365);
            });
            #endregion

            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5000/") });
            builder.Services.AddMsalAuthentication(options =>
            {
                builder.Configuration.Bind("AzureAd", options.ProviderOptions.Authentication);
            });

            //builder.Services.AddOidcAuthentication(options =>
            //{
            //    // Configure your authentication provider options here.
            //    // For more information, see https://aka.ms/blazor-standalone-auth
            //    builder.Configuration.Bind("Local", options.ProviderOptions);
            //});

            #region Seguridad
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<ProveedorAutenticacionJWT>();
            builder.Services.AddScoped<AuthenticationStateProvider, ProveedorAutenticacionJWT>(provider => provider.GetRequiredService<ProveedorAutenticacionJWT>());
            builder.Services.AddScoped<ILoginService, ProveedorAutenticacionJWT>(provider => provider.GetRequiredService<ProveedorAutenticacionJWT>());

            //builder.Services.AddAuthorizationCore();
            ////builder.Services.AddScoped<SecurityService>();
            //builder.Services.AddScoped<AuthenticationStateProvider, ProveedorAutenticacionPrueba>();
            ////builder.Services.AddScoped<AuthenticationStateProvider, ApplicationAuthenticationStateProvider>();
            #endregion

            #region Add
            builder.Services.AddScoped<TipoEmpleadoService>();
            builder.Services.AddScoped<EmpleadoService>();
            builder.Services.AddScoped<HoraService>();
            builder.Services.AddScoped<EspecialidadService>();
            builder.Services.AddScoped<MedicoService>();
            builder.Services.AddScoped<DiaSemanaService>();
            builder.Services.AddScoped<PacienteService>();
            builder.Services.AddScoped<HorarioAtencionService>();
            builder.Services.AddScoped<CitaService>();
            #endregion

            await builder.Build().RunAsync();
        }
    }
}