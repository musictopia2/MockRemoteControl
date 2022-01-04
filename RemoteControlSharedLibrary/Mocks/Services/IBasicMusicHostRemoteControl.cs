using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlSharedLibrary.Mocks.Services;

public interface IBasicMusicHostRemoteControl
{
    Func<Task>? Pause { get; set; } //did as delegate.  this means the host will need to populate  which can do anything.
    //can add any other methods as needed.
    //if you add other methods, then make sure they are the same for client.  otherwise, the communication will not work.
    //this system allows unlimited remote controls and unlimited possibilities for messages sent and received.

    Task InitializeAsync();
    //this would allow to send progress (or any information to the clients)
    //Task SendProgressAsync(MoviesModel movie);
}