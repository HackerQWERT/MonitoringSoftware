

namespace MonitoringSoftware.ViewModels;

public partial class RealTimeDetectionViewModel : BaseViewModel
{

	public RealTimeDetectionViewModel()
	{
        //Task.Run(async () => { await AddTemperaturePointer(); });
        //Task.Run(async () => { await AddPressurePointer(); });
        //Task.Run(async () => { await AddVibrationPointer(); });
        RegisterSingalRService();


    }
    void RegisterSingalRService()
    {   
        App.SignalR.msConnection.On<SensorDataModel>(SignalR.SingalRMethodName.MonitoringSoftwareMethod.RealTimeDetectionViewReceiveSensorData , (sensorDataModel) => 
        {
            TemperaturePointerValue = sensorDataModel.Temperature;
            PressurePointerValue = sensorDataModel.Pressure;
            VibrationPointerValue = sensorDataModel.Vibration;
        });
    }

 //   async Task AddTemperaturePointer()
	//{
	//	while(true)
	//	{
 //           TemperaturePointer += 10;
	//		if(TemperaturePointer > 100 )
 //               TemperaturePointer = -40;
 //           await Task.Delay(1000);

 //       }

 //   }
 //   async Task AddPressurePointer()
 //   {
 //       while (true)
 //       {
 //           PressurePointer += 10;
 //           if (PressurePointer > 100)
 //               PressurePointer = 0;
 //           await Task.Delay(1000);

 //       }

 //   }

 //   async Task AddVibrationPointer()
 //   {
 //       while (true)
 //       {
 //           VibrationPointer += 0.1f;
 //           if (VibrationPointer > 1)
 //               VibrationPointer = 0;
 //           await Task.Delay(1000);

 //       }

 //   }


    [ObservableProperty]
	double temperaturePointerValue;

    [ObservableProperty]
    double pressurePointerValue;

    [ObservableProperty]
    double vibrationPointerValue;

}