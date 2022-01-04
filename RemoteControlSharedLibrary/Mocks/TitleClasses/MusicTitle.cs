namespace RemoteControlSharedLibrary.Mocks.TitleClasses;
public class MusicTitle : IMusicTitle
{
    string ITitle.Title => "Mock Music"; //can be anything you want.  this identifies.  so even if you have several systems connected it will know who connects to who.
}