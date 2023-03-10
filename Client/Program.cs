using LexiconLMSBlazor.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace LexiconLMSBlazor.Client
{
    public class Program
    {
//        private static async Task DelayAsync()
//        {
//#if DEBUG
//            await Task.Delay(500);
//#endif
//        }

        public static async Task Main(string[] args)
        {
            //await DelayAsync();
            
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddHttpClient("LexiconLMSBlazor.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // NuGet: Microsoft.Extensions.Http
            builder.Services.AddHttpClient<IAppUserDtoClient, AppUserDtoClient>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("LexiconLMSBlazor.ServerAPI"));

            builder.Services.AddApiAuthorization();

            await builder.Build().RunAsync();
        }
    }
}