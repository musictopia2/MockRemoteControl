namespace RemoteControlSharedLibrary.Mocks.Services;
public interface IBasicOtherClientRemoteControl
{
    Task InitializeAsync();
    Action<string>? HostStateInfo { get; set; }
    Task SayHiAsync(); //pretend like its just saying hi just to show does not care what you do.
}