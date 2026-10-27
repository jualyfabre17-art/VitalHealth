namespace VitalHealth.Domain.Interfaces
{
    public interface INotification
    {
        Task  SendNotificationAsync (string message);
    }
}
