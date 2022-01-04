namespace Host.Blazor;
public partial class MainComponent
{
    [Inject]
    private IBasicMusicHostRemoteControl? _service { get; set; }
    private string _status = "None";
    protected override async Task OnInitializedAsync()
    {
        _service!.Pause = DoPauseAsync;
        await _service.InitializeAsync();
        TemporaryModel model = new($"Connected On {DateTime.Now}");
        await _service.SendConnectedAsync(model);
    }
    private async Task DoPauseAsync()
    {
        _status = $"Paused On {DateTime.Now}";
        await InvokeAsync(StateHasChanged);
    }
}