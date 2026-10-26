namespace VitalHealthAPI.Interfaces
{
    public interface INotification
    {
        Task  SendNotificationAsync (string message);
    }
}
