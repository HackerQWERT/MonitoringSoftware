namespace MonitoringSoftware.Views;

public partial class RealTimeDetectionView : ContentPage
{

    public RealTimeDetectionView(RealTimeDetectionViewModel realTimeDetectionViewModel)
    {
        this.BindingContext = realTimeDetectionViewModel;
        InitializeComponent();
    }
}