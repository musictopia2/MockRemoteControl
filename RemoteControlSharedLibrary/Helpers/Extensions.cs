namespace RemoteControlSharedLibrary.Helpers;
public static class Extensions
{
    private static IServiceCollection RegisterBasics(this IServiceCollection services)
    {
        services.AddSingleton<IRemoteControlEndPoint, EndPointClass>();
        return services;
    }
    private static IServiceCollection RegisterMusicTitle(this IServiceCollection services)
    {
        services.AddSingleton<IMusicTitle, MusicTitle>();
        return services;
    }
    public static IServiceCollection RegisterMockMusicClientRemoteControl(this IServiceCollection services)
    {
        services.RegisterBasics()
            .RegisterMusicTitle()
            .AddScoped<IBasicMusicClientRemoteControl, BasicMusicClientRemoteControl>();
        return services;
    }
    public static IServiceCollection RegisterMockMusicHostRemoteControl(this IServiceCollection services)
    {
        services.RegisterBasics()
            .RegisterMusicTitle()
            .AddScoped<IBasicMusicHostRemoteControl, BasicMusicHostRemoteControl>();
        return services;
    }
}