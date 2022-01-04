using RemoteControl.CoreLibrary.Helpers;
namespace RemoteControlCoreLibrary;
public class EndPointClass : IRemoteControlEndPoint
{
    string IRemoteControlEndPoint.EndPointAddress => "http://192.168.0.150:5252/remotecontrolhub";
    //notes:  make sure to change the 192.168.0.150 to the ip address you choose to use that all computers on your network can use.
    //also, make sure to change 5252 to the random port assigned when you create your server project.
    //the purpose of this interface is you use the interface and whatever you put here will be the url used.  allows for unlimited possibilities of where the hub is.
    //this is the server.  both the client and host care about the server, not each other.
}