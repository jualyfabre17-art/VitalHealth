using VitalHealthAPI.Interfaces;

namespace VitalHealthAPI.Service
{
    public class SmsNotification : INotification
    {
        public Task SendNotificationAsync(string message)
        {
            string shortMessage = message;

            if (shortMessage.Length > 105) 
            {
                shortMessage = shortMessage.Substring(0, 102) + "...";
            }

            Console.WriteLine($"SMS fugaz -> {shortMessage}");

            return Task.CompletedTask;
        }
    }
}
