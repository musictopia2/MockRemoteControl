namespace Host.Blazor;
public partial class Start
{
    public static Action? DoTab { get; set; }
    protected override void OnInitialized() //could not use the carl franklins video because i would need the id put to the div which usually they don't.  since my way worked before continue using it.
    {
        DoTab?.Invoke(); //workaround so the focus can work upon loading (if needed).
    }
}