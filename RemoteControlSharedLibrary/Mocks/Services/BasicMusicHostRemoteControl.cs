namespace RemoteControlSharedLibrary.Mocks.Services;
public class BasicMusicHostRemoteControl : BaseRemoteControlHostClass, IBasicMusicHostRemoteControl
{
    public BasicMusicHostRemoteControl(IRemoteControlEndPoint endPoint, IMusicTitle title) : base(endPoint, title)
    {
    }
    public Func<Task>? Pause { get; set; }

    public async Task SendConnectedAsync(TemporaryModel model)
    {
        await SendCustomDataAsync("Connected", model);
    }

    protected override void RegisterCustomMethods()
    {
        Hub!.On("Pause", () => Pause!.Invoke());
    }
}