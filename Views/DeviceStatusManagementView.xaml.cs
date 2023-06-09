namespace MonitoringSoftware.Views;

public partial class DeviceStatusManagementView : ContentPage
{

    public DeviceStatusManagementView(DeviceStatusManagementViewModel deviceStatusManagementViewModel)
    {
        this.BindingContext = deviceStatusManagementViewModel;
        InitializeComponent();
 
    }



}