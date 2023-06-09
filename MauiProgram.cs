namespace MonitoringSoftware;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif
        #region Views
        builder.Services.AddSingleton<RealTimeDetectionView>();
        builder.Services.AddSingleton<DeviceStatusManagementView>();
        builder.Services.AddSingleton<EquipmentMaintenanceRecordsView>();
        builder.Services.AddSingleton<ReportGenerationView>();
        #endregion

        #region ViewModels
        builder.Services.AddSingleton<RealTimeDetectionViewModel>();
        builder.Services.AddSingleton<DeviceStatusManagementViewModel>();
        builder.Services.AddSingleton<EquipmentMaintenanceRecordsViewModel>();
        builder.Services.AddSingleton<ReportGenerationViewModel>();
        #endregion

        #region Services
        builder.Services.AddSingleton<SignalR>();
        #endregion

        return builder.Build();
    }
}