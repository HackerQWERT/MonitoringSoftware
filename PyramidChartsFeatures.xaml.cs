namespace MonitoringSoftware;
///<summary>
///PyramidChartsFeatures class
///</summary>
public partial class PyramidChartsFeatures : ContentPage
{
///<summary>
///PyramidChartsFeatures constructor
///</summary>
	public PyramidChartsFeatures()
	{
		InitializeComponent();
	}
}
///<summary>
///ViewModel class for the PyramidChartsFeatures 
///</summary>
public class ChartViewModel
{
	public List<Stage> Data { get; set; }
	///<summary>
	///ViewModel class constructor for the PyramidChartsFeatures 
	///</summary>
	public ChartViewModel()
	{
		Data = new List<Stage>()
		{
			new Stage(){Name = "Stage A", Value = 12},
			new Stage(){Name = "Stage B", Value = 21},
			new Stage(){Name = "Stage C", Value = 29},
			new Stage(){Name = "Stage D", Value = 37},
		};
	}
}
///<summary>
///Model class for the PyramidChartsFeatures 
///</summary>
public class Stage
{
	public string Name { get; set; }
	public double Value { get; set; }
}
