namespace ConsoleApp.CustomTypes
{
    [Flags]
    enum CarOptions
    {
        None = 0,
        Sunroof = 2,
        LeatherSeats = 4,
        NavigationSystem = 8,
        Bluetooth = 16,
        HeatedSeats = 32,
        BackupCamera = 64,
        AllWheelDrive= 128
    }
}