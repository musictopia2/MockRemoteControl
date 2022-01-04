namespace RemoteControlSharedLibrary.Mocks.Services;
public class BasicMusicHostRemoteControl : BaseRemoteControlHostClass, IBasicMusicHostRemoteControl
{
    public BasicMusicHostRemoteControl(IRemoteControlEndPoint endPoint, ITitle title) : base(endPoint, title)
    {
    }
    public Func<Task>? Pause { get; set; }
}