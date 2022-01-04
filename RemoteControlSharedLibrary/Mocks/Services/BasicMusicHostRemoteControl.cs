namespace RemoteControlSharedLibrary.Mocks.Services;
public class BasicMusicHostRemoteControl : BaseRemoteControlHostClass, IBasicMusicHostRemoteControl
{
    public BasicMusicHostRemoteControl(IRemoteControlEndPoint endPoint, IMusicTitle title) : base(endPoint, title)
    {
    }
    public Func<Task>? Pause { get; set; }
}