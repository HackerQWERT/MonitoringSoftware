namespace MonitoringSoftware;
///<summary>
///FunnelChartsFeatures class
///</summary>
public partial class FunnelChartsFeatures : ContentPage
{
	///<summary>
    ///FunnelChartsFeatures constructor
    ///</summary>
	public FunnelChartsFeatures()
	{
		InitializeComponent();
	}
}
///<summary>
///FunnelChartsFeatures Model class
///</summary>
public class Admission
{
	public string XValue { get; set; }
	public double YValue { get; set; }
}
///<summary>
///FunnelChartsFeatures ViewModel class
///</summary>
public class FunnelChartViewModel
{
	public List<Admission> Data { get; set; }
	///<summary>
    ///FunnelChartsFeatures ViewModel class constructor
    ///</summary>
	public FunnelChartViewModel()
	{
		Data = new List<Admission>()
		{
			new Admission() {XValue = "Enrolled", YValue=175},
			new Admission() {XValue = "Admits", YValue=190},
			new Admission() {XValue = "Applicants", YValue=245},
			new Admission() {XValue = "Inquiries ", YValue=290},
			new Admission() {XValue = "Prospects ", YValue=320},
		};
	}
}
