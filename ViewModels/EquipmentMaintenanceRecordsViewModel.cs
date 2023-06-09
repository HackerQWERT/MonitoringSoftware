using System.Diagnostics;

namespace MonitoringSoftware.ViewModels;

public partial class EquipmentMaintenanceRecordsViewModel : BaseViewModel
{

	public EquipmentMaintenanceRecordsViewModel()
	{
        try
        { 
            RegisterSingalRService();
        }
        catch (Exception ex) 
        {
            Debug.WriteLine(ex.Message);
        }
        Task.Run(() => SendIntervalRequestAsync()) ;
    }

    async Task SendIntervalRequestAsync()
    {
        while(true)
        {
            var v= App.SignalR.msConnection.SendAsync(SignalR.SingalRMethodName.MonitoringSoftwareHubMethod.ReceiveVibrationRequestFromEquipmentMaintenanceRecordsView, 1);
            var p= App.SignalR.msConnection.SendAsync(SignalR.SingalRMethodName.MonitoringSoftwareHubMethod.ReceivePressureRequestFromEquipmentMaintenanceRecordsView, 1);
            var t= App.SignalR.msConnection.SendAsync(SignalR.SingalRMethodName.MonitoringSoftwareHubMethod.ReceiveTemperatureRequestFromEquipmentMaintenanceRecordsView, 1);
            await Task.WhenAll(v,p,t);
            await Task.Delay(5000);
        }

    }
    void RegisterSingalRService()
    {
        App.SignalR.msConnection.On<List<VibrationSensorLogModel>>(SignalR.SingalRMethodName.MonitoringSoftwareMethod.EquipmentMaintenanceRecordsViewReceiveVibrationSensorLogs, (vibrationSensorLogModels) =>
        {
            VibrationSensorLogModels.Clear();
            foreach(var v in vibrationSensorLogModels)
            {
                VibrationSensorLogModels.Add(v);
            }
        });
        App.SignalR.msConnection.On<List<PressureSensorLogModel>>(SignalR.SingalRMethodName.MonitoringSoftwareMethod.EquipmentMaintenanceRecordsViewReceivePressureSensorLogs, (pressureSensorLogModels) =>
        {
            PressureSensorLogModels.Clear();
            foreach (var v in pressureSensorLogModels)
            {
                PressureSensorLogModels.Add(v);
            }
        });
        App.SignalR.msConnection.On<List<TemperatureSensorLogModel>>(SignalR.SingalRMethodName.MonitoringSoftwareMethod.EquipmentMaintenanceRecordsViewReceiveTemperatureSensorLogs, (temperatureSensorLogModels) =>
        {
            TemperatureSensorLogModels.Clear();
            foreach (var v in temperatureSensorLogModels)
            {
                TemperatureSensorLogModels.Add(v);
            }
        });
    }
    [ObservableProperty]
	ObservableCollection<TemperatureSensorLogModel> temperatureSensorLogModels=new() 
	{
		//new TemperatureSensorLogModel() {Id=Random.Shared.Next(),Time=DateTime.Now,Temperature=Random.Shared.NextDouble()*100,DeviceStatus=true,FaultCondition=false},
		//new TemperatureSensorLogModel() {Id=Random.Shared.Next(),Time=DateTime.Now,Temperature=Random.Shared.NextDouble()*100,DeviceStatus=true,FaultCondition=false},
		//new TemperatureSensorLogModel() {Id=Random.Shared.Next(),Time=DateTime.Now,Temperature=Random.Shared.NextDouble()*100,DeviceStatus=true,FaultCondition=false},
		//new TemperatureSensorLogModel() {Id=Random.Shared.Next(),Time=DateTime.Now,Temperature=Random.Shared.NextDouble()*100,DeviceStatus=true,FaultCondition=false},
		//new TemperatureSensorLogModel() {Id=Random.Shared.Next(),Time=DateTime.Now,Temperature=Random.Shared.NextDouble()*100,DeviceStatus=true,FaultCondition=false},
		//new TemperatureSensorLogModel() {Id=Random.Shared.Next(),Time=DateTime.Now,Temperature=Random.Shared.NextDouble()*100,DeviceStatus=true,FaultCondition=false},
		//new TemperatureSensorLogModel() {Id=Random.Shared.Next(),Time=DateTime.Now,Temperature=Random.Shared.NextDouble()*100,DeviceStatus=true,FaultCondition=false},
		//new TemperatureSensorLogModel() {Id=Random.Shared.Next(),Time=DateTime.Now,Temperature=Random.Shared.NextDouble()*100,DeviceStatus=true,FaultCondition=false},
  //      new TemperatureSensorLogModel() {Id=Random.Shared.Next(),Time=DateTime.Now,Temperature=Random.Shared.NextDouble()*100,DeviceStatus=true,FaultCondition=false},
	
	};
  
	[ObservableProperty]
    ObservableCollection<PressureSensorLogModel> pressureSensorLogModels = new()
	{
 //       new PressureSensorLogModel(){Id=Random.Shared.Next(),Time=DateTime.Now,Pressure=Random.Shared.NextDouble()*100,DeviceStatus=true,FaultCondition=false},
 //       new PressureSensorLogModel(){Id=Random.Shared.Next(),Time=DateTime.Now,Pressure=Random.Shared.NextDouble()*100,DeviceStatus=true,FaultCondition=false},
 //       new PressureSensorLogModel(){Id=Random.Shared.Next(),Time=DateTime.Now,Pressure=Random.Shared.NextDouble()*100,DeviceStatus=true,FaultCondition=false},
 //       new PressureSensorLogModel(){Id=Random.Shared.Next(),Time=DateTime.Now,Pressure=Random.Shared.NextDouble()*100,DeviceStatus=true,FaultCondition=false},
 //       new PressureSensorLogModel(){Id=Random.Shared.Next(),Time=DateTime.Now,Pressure=Random.Shared.NextDouble()*100,DeviceStatus=true,FaultCondition=false},
	};


    [ObservableProperty]
    ObservableCollection<VibrationSensorLogModel> vibrationSensorLogModels = new()
	{ 
    //    new VibrationSensorLogModel(){Id=Random.Shared.Next(),Time=DateTime.Now,Vibration=Random.Shared.NextDouble()*100,DeviceStatus=true,FaultCondition=false},
    //    new VibrationSensorLogModel(){Id=Random.Shared.Next(),Time=DateTime.Now,Vibration=Random.Shared.NextDouble()*100,DeviceStatus=true,FaultCondition=false},
    //    new VibrationSensorLogModel(){Id=Random.Shared.Next(),Time=DateTime.Now,Vibration=Random.Shared.NextDouble()*100,DeviceStatus=true,FaultCondition=false},
    //    new VibrationSensorLogModel(){Id=Random.Shared.Next(),Time=DateTime.Now,Vibration=Random.Shared.NextDouble()*100,DeviceStatus=true,FaultCondition=false},
    //    new VibrationSensorLogModel(){Id=Random.Shared.Next(),Time=DateTime.Now,Vibration=Random.Shared.NextDouble()*100,DeviceStatus=true,FaultCondition=false},
    //    new VibrationSensorLogModel(){Id=Random.Shared.Next(),Time=DateTime.Now,Vibration=Random.Shared.NextDouble()*100,DeviceStatus=true,FaultCondition=false},
    //    new VibrationSensorLogModel(){Id=Random.Shared.Next(),Time=DateTime.Now,Vibration=Random.Shared.NextDouble()*100,DeviceStatus=true,FaultCondition=false},

    };

}