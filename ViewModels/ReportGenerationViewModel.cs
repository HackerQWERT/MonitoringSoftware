namespace MonitoringSoftware.ViewModels;

public partial class ReportGenerationViewModel : BaseViewModel
{

	public ReportGenerationViewModel()
	{
   
        TemperatureSensorModels = new ObservableCollection<TemperatureSensorModel>
        {
            new TemperatureSensorModel(){Range="-40~-30",Count=Random.Shared.Next(0,100)},
            new TemperatureSensorModel(){Range="-30~20",Count=Random.Shared.Next(0,100)},
            new TemperatureSensorModel(){Range="-20~-10",Count=Random.Shared.Next(0,100)},
            new TemperatureSensorModel(){Range="-10~0",Count=Random.Shared.Next(0,100)},
            new TemperatureSensorModel(){Range="0~10",Count=Random.Shared.Next(0,100)},
            new TemperatureSensorModel(){Range="10~20",Count=Random.Shared.Next(0,100)},
            new TemperatureSensorModel(){Range="20~30",Count=Random.Shared.Next(0,100)},
            new TemperatureSensorModel(){Range="30~40",Count=Random.Shared.Next(0, 100)},
            new TemperatureSensorModel(){Range="40~50",Count=Random.Shared.Next(0, 100)},
            new TemperatureSensorModel(){Range="50~60",Count=Random.Shared.Next(0, 100)},
            new TemperatureSensorModel(){Range="60~70",Count=Random.Shared.Next(0, 100)},
            new TemperatureSensorModel(){Range="70~80",Count=Random.Shared.Next(0, 100)},
            new TemperatureSensorModel(){Range="80~90",Count=Random.Shared.Next(0, 100)},
            new TemperatureSensorModel(){Range="90~100",Count=Random.Shared.Next(0, 100)},
        };
        PressureSensorModels = new ObservableCollection<PressureSensorModel>
        {
            new PressureSensorModel(){Range="0~10",Count=Random.Shared.Next(0,100)},
            new PressureSensorModel(){Range="10~20",Count=Random.Shared.Next(0,100)},
            new PressureSensorModel(){Range="20~30",Count=Random.Shared.Next(0,100)},
            new PressureSensorModel(){Range="30~40",Count=Random.Shared.Next(0,100)},
            new PressureSensorModel(){Range="40~50",Count=Random.Shared.Next(0,100)},
            new PressureSensorModel(){Range="50~60",Count=Random.Shared.Next(0,100)},
            new PressureSensorModel(){Range="60~70",Count=Random.Shared.Next(0,100)},
            new PressureSensorModel(){Range="70~80",Count=Random.Shared.Next(0,100)},
            new PressureSensorModel(){Range="80~90",Count=Random.Shared.Next(0,100)},
            new PressureSensorModel(){Range="90~100",Count=Random.Shared.Next(0,100)},

        };
        VibrationSensorModels = new ObservableCollection<VibrationSensorModel>
        {
            new VibrationSensorModel(){Range="0~0.1",Count=Random.Shared.Next(0,100)},
            new VibrationSensorModel(){Range="0.1~0.2",Count=Random.Shared.Next(0,100)},
            new VibrationSensorModel(){Range="0.2~0.3",Count=Random.Shared.Next(0,100)},
            new VibrationSensorModel(){Range="0.3~0.4",Count=Random.Shared.Next(0,100)},
            new VibrationSensorModel(){Range="0.4~0.5",Count=Random.Shared.Next(0,100)},
            new VibrationSensorModel(){Range="0.5~0.6",Count=Random.Shared.Next(0,100)},
            new VibrationSensorModel(){Range="0.6~0.7",Count=Random.Shared.Next(0,100)},
            new VibrationSensorModel(){Range="0.7~0.8",Count=Random.Shared.Next(0,100)},
            new VibrationSensorModel(){Range="0.8~0.9",Count=Random.Shared.Next(0,100)},
            new VibrationSensorModel(){Range="0.9~1.0",Count=Random.Shared.Next(0,100)},
        };

        //Data = new List<Person>()
        //{
        //    new Person { Name = "David", Height = 170 },
        //    new Person { Name = "Michael", Height = 96 },
        //    new Person { Name = "Steve", Height = 65 },
        //    new Person { Name = "Joel", Height = 182 },
        //    new Person { Name = "Bob", Height = 134 }
        //};
    }
    [ObservableProperty]
    public ObservableCollection<TemperatureSensorModel> temperatureSensorModels = new();

    [ObservableProperty]
    public ObservableCollection<PressureSensorModel> pressureSensorModels = new();

    [ObservableProperty]
    public ObservableCollection<VibrationSensorModel> vibrationSensorModels = new();

    //public List<Person> Data { get; set; }
}
//public class Person
//{
//    public string Name { get; set; }
//    public double Height { get; set; }
//}
