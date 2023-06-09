namespace MonitoringSoftware;

public partial class App : Application
{
    public static SignalR SignalR { get; set; }
    public App(SignalR signaR)
    {
        App.SignalR = signaR;

        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Your Licensing");
        InitializeComponent();
        MainPage = new AppShell();
    }
}
