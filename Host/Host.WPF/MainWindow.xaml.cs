namespace Host.WPF;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddBlazorWebView();
		serviceCollection.RegisterWPFServices();
        serviceCollection.RegisterBlazorBeginningClasses();
        serviceCollection.RegisterMockMusicHostRemoteControl();
        //here is where i do other services.
        //if i need to change title from view model, etc, rethink.
        Resources.Add("services", serviceCollection.BuildServiceProvider());
        Start.DoTab = () =>
        {
            tt.StartTabProcesses();
        };
        InitializeComponent();
    }
}