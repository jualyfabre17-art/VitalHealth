using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;
using VitalHealthAPI.migrations;
using VitalHealthAPI.Entities;

namespace VitalHealthAPI.Service
{
    public class AppointmentReservationService
    {
        private readonly AppointmentDbContext DbContext;

        public AppointmentReservationService(AppointmentDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<bool> AvailableAppointment( int roomId, DateTime startDateProposed, DateTime endDateProposed)
        {
            bool isNotAvailable = await DbContext.Appointments
                .AsNoTracking()
                .Where(r => r.RoomId == roomId)
                .AnyAsync(r => r.StartDate < endDateProposed && r.EndDate > startDateProposed);

            return !isNotAvailable;
        }
    }
}
