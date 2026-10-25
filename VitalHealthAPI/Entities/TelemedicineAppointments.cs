namespace VitalHealthAPI.Entities
{
    public class TelemedicineAppointments : Appointment
    {
        public string MeetingLink { get; set; } = string.Empty;

        public TelemedicineAppointments(string appointmentOwner, string title, string description, int patientId, int doctorId, int roomId, DateTime startDate, DateTime endDate, string meetingLink)
            : base(appointmentOwner, title, description, patientId, doctorId, roomId, startDate, endDate) 
        {
            if (string.IsNullOrWhiteSpace(meetingLink))
            {
                throw new ArgumentException("El enlace es invalido", nameof(meetingLink));
            }
        }
        public override TimeSpan MinimumDuration() => TimeSpan.FromMinutes(25);
        public override bool ConfirmationPhysicalRequeriments() => false;
    }
}
