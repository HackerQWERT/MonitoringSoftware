using System.Diagnostics;
using System.Reflection.PortableExecutable;

namespace MonitoringSoftware.Services;

public class SignalR
{
    public HubConnection msConnection;
    static string ip = "10.0.2.2";
    static string port = "5147";
    string url = $"http://{ip}:{port}/MonitoringSoftwareHub";

    public SignalR()
	{
        msConnection = new HubConnectionBuilder()
         .WithUrl(url)
         .Build();

        msConnection.Closed += async (error) =>
        {
            // 连接关闭时尝试重新连接
            await msConnection.StartAsync();

        };
        Task.Run(()=>ConnectToServer());
        Task.Run(()=> ReconnectToServer());
     

    }
    async Task ReconnectToServer()
    {
        while(true)
        {
            await Task.Delay(5000);
            if(msConnection.State is not HubConnectionState.Connected)
            {
                await msConnection.StopAsync();
                await msConnection.StartAsync();
            }
        }

    }

    async Task ConnectToServer()
    {
        try
        {
            await msConnection.StartAsync();
        }
        catch(Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
        finally
        {
            if (msConnection.State is HubConnectionState.Connected)
                Debug.WriteLine("连上网络.......................");
            else
                Debug.WriteLine("未连上网络.......................");
        }

    }

    public static class SingalRMethodName
    {
        public static class MonitoringSoftwareHubMethod
        {
            public static string ReceiveTemperatureSensorLogFromDeviceStatusManagementView { get; } = "ReceiveTemperatureSensorLogFromDeviceStatusManagementView";
            public static string ReceivePressureSensorLogFromDeviceStatusManagementView { get; } = "ReceivePressureSensorLogFromDeviceStatusManagementView";
            public static string ReceiveVibrationSensorLogFromDeviceStatusManagementView { get; } = "ReceiveVibrationSensorLogFromDeviceStatusManagementView";



            public static string ReceiveVibrationRequestFromEquipmentMaintenanceRecordsView { get; } = "ReceiveVibrationRequestFromEquipmentMaintenanceRecordsView";
            public static string ReceivePressureRequestFromEquipmentMaintenanceRecordsView { get; } = "ReceivePressureRequestFromEquipmentMaintenanceRecordsView";
            public static string ReceiveTemperatureRequestFromEquipmentMaintenanceRecordsView { get; } = "ReceiveTemperatureRequestFromEquipmentMaintenanceRecordsView";

        }
        public static class SensorHubMethod
        {
            public static string ReceiveSensorData { get; set; } = "ReceiveSensorData";
        }


        public static class MonitoringSoftwareMethod
        {
            //public static string ReceiveAndHandleMonitoringSoftwareSensorData { get; set; } = "ReceiveAndHandleMonitoringSoftwareSensorData";
            public static string RealTimeDetectionViewReceiveSensorData {  get; } = "RealTimeDetectionViewReceiveSensorData";
            public static string DeviceStatusManagementViewCheckIfTheThresholdIsExceeded { get; } = "DeviceStatusManagementViewCheckIfTheThresholdIsExceeded";
            public static string EquipmentMaintenanceRecordsViewReceiveVibrationSensorLogs {  get; } = "EquipmentMaintenanceRecordsViewReceiveVibrationSensorLogs";
            public static string EquipmentMaintenanceRecordsViewReceivePressureSensorLogs {  get; } = "EquipmentMaintenanceRecordsViewReceivePressureSensorLogs";
            public static string EquipmentMaintenanceRecordsViewReceiveTemperatureSensorLogs {  get; } = "EquipmentMaintenanceRecordsViewReceiveTemperatureSensorLogs";
    
        }
        public static class SensorMethod
        {


        }
     

    }


}


