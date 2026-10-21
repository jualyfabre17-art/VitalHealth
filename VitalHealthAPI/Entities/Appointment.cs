namespace VitalHealthAPI.Entities
{
    public class Appointment
    {
        public int Id { get; private set; }
        public string AppointmentOwner { get; private set; } = string.Empty;
        public string Title { get; private set; } = string.Empty;
        public string Description { get;  private set; } = string.Empty;
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public int PatientId { get; private set; }
        public Patient Patient { get; private set; } = null!;

        public int DoctorId { get; private set; }
        public Doctor Doctor { get; private set; } = null!;
        
        protected Appointment() { }

        public Appointment(string appointmentOwner,string title, string description, int patientId, int doctorId, DateTime startDate, DateTime endDate)
        {
            if (string.IsNullOrWhiteSpace(appointmentOwner))
            {
                throw new ArgumentException("Propiertario de la cita invalido", nameof(appointmentOwner));
            }
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Titulo invalido", nameof(title));
            }
            if(string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Descripcion invalida, ingrese una correcta", nameof(description));
            }
            if (patientId <= 0)
            {
                throw new ArgumentOutOfRangeException("El paciente es invalido", nameof(patientId));
            }
            if (doctorId <=0)
            {
                throw new ArgumentOutOfRangeException("Doctor invalido", nameof(doctorId));
            }
            if(startDate >= endDate)
            {
                throw new ArgumentOutOfRangeException("La fecha de inicio es invalida", nameof(startDate));
            }

            AppointmentOwner = appointmentOwner;
            Title = title;
            Description = description;
            PatientId = patientId;
            DoctorId = doctorId;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
