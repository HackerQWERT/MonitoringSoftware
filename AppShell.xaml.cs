namespace MonitoringSoftware
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Routing.RegisterRoute(nameof(RealTimeDetectionView), typeof(RealTimeDetectionView));
            Routing.RegisterRoute(nameof(DeviceStatusManagementView), typeof(DeviceStatusManagementView));
            Routing.RegisterRoute(nameof(EquipmentMaintenanceRecordsView), typeof(EquipmentMaintenanceRecordsView));
            Routing.RegisterRoute(nameof(ReportGenerationView), typeof(ReportGenerationView));
            InitializeComponent(); 
        }
    }
}