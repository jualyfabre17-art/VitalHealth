using VitalHealthAPI.Interfaces;

namespace VitalHealthAPI.Service
{
    public class EmailNotification: INotification
    {
        public async  Task SendNotificationAsync(string message)
        {
            await Task.Delay(1000);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("DE: sistema@vitalhealth.com");
            Console.WriteLine("ASUNTO: Notificacion de su cita medica");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Estimado paciente,Le escribimos para informarle lo siguiente:{message}");
        }
    }
}

