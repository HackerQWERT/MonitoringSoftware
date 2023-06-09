namespace MonitoringSoftware.Views;

public partial class EquipmentMaintenanceRecordsView : ContentPage
{

    public EquipmentMaintenanceRecordsView(EquipmentMaintenanceRecordsViewModel equipmentMaintenanceRecordsViewModel)
    {
        this.BindingContext = equipmentMaintenanceRecordsViewModel;
        InitializeComponent();
 
    }



}