namespace MonitoringSoftware.Views;

public partial class ReportGenerationView : ContentPage
{

    public ReportGenerationView(ReportGenerationViewModel reportGenerationViewModel)
    {
        this.BindingContext = reportGenerationViewModel;
        InitializeComponent();
 
    }



}