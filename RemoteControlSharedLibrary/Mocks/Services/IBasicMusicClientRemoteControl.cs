using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlSharedLibrary.Mocks.Services;

public interface IBasicMusicClientRemoteControl
{
    Task PauseAsync();
    Task InitializeAsync();
    Action<string>? HostStateInfo { get; set; }
}