namespace RemoteControlSharedLibrary.Mocks.Services;
public class BasicMusicClientRemoteControl : BaseRemoteControlClientClass, IBasicMusicClientRemoteControl
{
    public BasicMusicClientRemoteControl(IRemoteControlEndPoint endPoint, IMusicTitle title) : base(endPoint, title)
    {
    }
    public async Task PauseAsync()
    {
        await SendSimpleActionAsync("Pause");
    }
    protected override void RegisterCustomMethods()
    {
        //you can register custom methods as well.  this means it can show progress.
        //you need a model and the name (which must the same for both client and host).
        //the commented is what i did for my movie remote control.  obviously, we don't have the movie model to work with here.
        //Hub!.RegisterGenericMethod<MoviesModel>("Progress", item => MoviesUpdate?.Invoke(item));
    }
}