using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlSharedLibrary.Mocks.Pages;

public partial class MockMusicRemoteControlPage
{
    [Inject]
    private IBasicMusicClientRemoteControl? DataContext { get; set; }
    private string _status = "None";
    private string _others = "";
    protected override async Task OnInitializedAsync()
    {
        DataContext!.HostStateInfo = item =>
        {
            _status = item;
            InvokeAsync(StateHasChanged);
        };
        DataContext.HostConnect = item =>
        {
            _status = "";
            _others = item.Information;
            InvokeAsync(StateHasChanged);
        };
        //DataContext!.MoviesUpdate = item =>
        //{
        //    _status = "";
        //    _currentMovie = item;
        //    InvokeAsync(StateHasChanged);
        //};
        await DataContext!.InitializeAsync();
    }
}
