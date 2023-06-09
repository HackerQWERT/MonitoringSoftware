namespace MonitoringSoftware.ViewModels;

public partial class DeviceStatusManagementViewModel : BaseViewModel
{

    public DeviceStatusManagementViewModel()
    {
        RegisterSingalRService();


    }
    //注册RPC服务
    void RegisterSingalRService()
    {
        App.SignalR.msConnection.On<SensorDataModel>(SignalR.SingalRMethodName.MonitoringSoftwareMethod.DeviceStatusManagementViewCheckIfTheThresholdIsExceeded, (sensorDataModel) =>
        {
            CurrentTemperature = sensorDataModel.Temperature;
            CurrentPressure = sensorDataModel.Pressure;
            CurrentVibration = sensorDataModel.Vibration;
            if (CurrentTemperature > ThresholdTemperatue)
                IsTemperatueSensorNormal=false;
            if(CurrentPressure > ThresholdTemperatue)
                IsPressureSensorNormal=false;
            if(CurrentVibration>ThresholdVibration)
                IsVibrationSensorNormal=false;   
        });
    }

    //设置设备状态 故障情况
    [RelayCommand]
    void SetTemperatureSensorStatus()
    {
        IsTemperatueSensorOpen = !IsTemperatueSensorOpen;
        TemperatureSensorLogModel temperatureSensorLogModel = new TemperatureSensorLogModel()
        {
            Time = DateTime.Now,
            Temperature = CurrentTemperature,
            DeviceStatus= IsTemperatueSensorOpen,
            FaultCondition=IsPressureSensorNormal
        };  
        App.SignalR.msConnection.SendAsync(SignalR.SingalRMethodName.MonitoringSoftwareHubMethod.ReceiveTemperatureSensorLogFromDeviceStatusManagementView,temperatureSensorLogModel);
    }
    [RelayCommand]
    void RepairTemperatureSensor()
    {
        CurrentTemperature = 40;
        IsTemperatueSensorNormal=true;

        TemperatureSensorLogModel temperatureSensorLogModel = new TemperatureSensorLogModel()
        {
            Time = DateTime.Now,
            Temperature = CurrentTemperature,
            DeviceStatus = IsTemperatueSensorOpen,
            FaultCondition = IsPressureSensorNormal
        };
        App.SignalR.msConnection.SendAsync(SignalR.SingalRMethodName.MonitoringSoftwareHubMethod.ReceiveTemperatureSensorLogFromDeviceStatusManagementView, temperatureSensorLogModel);

    }

    [RelayCommand]
    void SetPressureSensorStatus()
    {
        IsPressureSensorOpen = !IsPressureSensorOpen;
      
        PressureSensorLogModel pressureSensorLogModel = new PressureSensorLogModel()
        {
            Time = DateTime.Now,
            Pressure = CurrentPressure,
            DeviceStatus = IsTemperatueSensorOpen,
            FaultCondition = IsPressureSensorNormal
        };
        App.SignalR.msConnection.SendAsync(SignalR.SingalRMethodName.MonitoringSoftwareHubMethod.ReceivePressureSensorLogFromDeviceStatusManagementView, pressureSensorLogModel);

    }
    [RelayCommand]
    void RepairPressureSensor()
    {
        CurrentPressure = 40;
        IsPressureSensorNormal= true;

        PressureSensorLogModel pressureSensorLogModel = new PressureSensorLogModel()
        {
            Time = DateTime.Now,
            Pressure = CurrentPressure,
            DeviceStatus = IsTemperatueSensorOpen,
            FaultCondition = IsPressureSensorNormal
        };
        App.SignalR.msConnection.SendAsync(SignalR.SingalRMethodName.MonitoringSoftwareHubMethod.ReceivePressureSensorLogFromDeviceStatusManagementView, pressureSensorLogModel);

    }

    [RelayCommand]
    void SetVibrationSensorStatus()
    {
        IsVibrationSensorOpen = !IsVibrationSensorOpen;

        VibrationSensorLogModel vibrationSensorLogModel = new VibrationSensorLogModel()
        {
            Time = DateTime.Now,
            Vibration = CurrentVibration,
            DeviceStatus = IsTemperatueSensorOpen,
            FaultCondition = IsPressureSensorNormal
        };
        App.SignalR.msConnection.SendAsync(SignalR.SingalRMethodName.MonitoringSoftwareHubMethod.ReceiveVibrationSensorLogFromDeviceStatusManagementView, vibrationSensorLogModel);

    }
    [RelayCommand]
    void RepairVibrationSensor()
    {
        CurrentVibration= 0.5;
        IsVibrationSensorNormal = true;

        VibrationSensorLogModel vibrationSensorLogModel = new VibrationSensorLogModel()
        {
            Time = DateTime.Now,
            Vibration = CurrentVibration,
            DeviceStatus = IsTemperatueSensorOpen,
            FaultCondition = IsPressureSensorNormal
        };
        App.SignalR.msConnection.SendAsync(SignalR.SingalRMethodName.MonitoringSoftwareHubMethod.ReceiveVibrationSensorLogFromDeviceStatusManagementView, vibrationSensorLogModel);

    }


    //设置传感器阈值
    [RelayCommand]
    void SetThresholdTemperature()
    {
        ThresholdTemperatue = EntryThresholdTemperatueValue;
    }

    [RelayCommand]
    void SetThresholdPressure()
    {
        ThresholdPressure = EntryThresholdPressureValue;

    }

    [RelayCommand]
    void SetThresholdVibration()
    {
        ThresholdVibration = EntryThresholdVibrationValue ;

    }

    //输入阈值
    [ObservableProperty]
    double entryThresholdTemperatueValue;

    [ObservableProperty]
    double entryThresholdPressureValue;

    [ObservableProperty]
    double entryThresholdVibrationValue;

    //当前阈值
    [ObservableProperty]
    double thresholdTemperatue = 70;

    [ObservableProperty]
    double thresholdPressure = 70;

    [ObservableProperty]
    double thresholdVibration = 0.9;


    //当前传感器值
    [ObservableProperty]
    double currentTemperature;

    [ObservableProperty]
    double currentPressure;

    [ObservableProperty]
    double currentVibration;

    //设备状态
    [ObservableProperty]
    bool isTemperatueSensorNormal;
  
    [ObservableProperty]
    bool isPressureSensorNormal;

    [ObservableProperty]
    bool isVibrationSensorNormal;

    //设备是否打开
    [ObservableProperty]
    bool isTemperatueSensorOpen;

    [ObservableProperty]
    bool isPressureSensorOpen;

    [ObservableProperty]
    bool isVibrationSensorOpen;

}