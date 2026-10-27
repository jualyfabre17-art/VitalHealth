namespace VitalHealth.Domain.Entities
{
    public class InPersonAppointments : Appointment
    {
        public int NumberOffice { get; set; }

        public InPersonAppointments(string appointmentOwner, string title, string description, int patientId, int doctorId, int roomId, DateTime startDate, DateTime endDate, int numberOffice) 
            : base (appointmentOwner, title, description,patientId, doctorId, roomId, startDate, endDate)
        {
            if (numberOffice <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numberOffice), "Numero de consultorio Invalido");
            }
        }
        
        public override TimeSpan MinimumDuration() => TimeSpan.FromMinutes(45);
        public override bool ConfirmationPhysicalRequeriments() => true;
    }
}
