using Microsoft.EntityFrameworkCore;
using VitalHealth.Domain.Interfaces;
namespace VitalHealth.Application.Service
{
    public class AppointmentReservationService
    {
        private readonly IApplicationDbContext DbContext;
        private readonly INotification _notifyUser;

        public AppointmentReservationService(IApplicationDbContext dbContext, INotification notifyUser)
        {
            DbContext = dbContext;
            _notifyUser = notifyUser;
        }

        public async Task<bool> AvailableAppointment( int doctorId, DateTime startDateProposed, DateTime endDateProposed)
        {
            bool isNotAvailable = await DbContext.Appointments
                .AsNoTracking()
                .Where(r => r.DoctorId == doctorId)
                .AnyAsync(r => r.StartDate < endDateProposed && r.EndDate > startDateProposed);

            return !isNotAvailable;
        }

        public void PatientNotification (string message)
        {
            Task notification = _notifyUser.SendNotificationAsync( message);
            Console.WriteLine(notification);
        }
    }
}
