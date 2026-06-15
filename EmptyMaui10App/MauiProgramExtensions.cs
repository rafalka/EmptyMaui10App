#if IOS
#warning Building EmptyMaui10App for iOS
#elif ANDROID
#warning Building EmptyMaui10App for Android
#else
#warning Building EmptyMaui10App for .NET core
#endif

using Microsoft.Extensions.Logging;

namespace EmptyMaui10App
{
    public static class MauiProgramExtensions
    {
        public static MauiAppBuilder UseSharedMauiApp(this MauiAppBuilder builder)
        {
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder;
        }
    }
}
