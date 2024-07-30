using CommunityToolkit.Maui;
using groceryApp.Pages;
using groceryApp.Services;
using groceryApp.ViewModels;
using Microsoft.Extensions.Logging;

namespace groceryApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("Ubuntu-Regular.ttf", "UbuntuRegular");
                    fonts.AddFont("Ubuntu-Bold.ttf", "UbuntuSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            //pages
            builder.Services.AddSingleton<HomePage>();
            //viewmodels
            builder.Services.AddSingleton<HomePageViewModel>();
            //services
            builder.Services.AddSingleton<CategoryService>();
            builder.Services.AddTransient<OfferService>();
            return builder.Build();
        }
    }
}
