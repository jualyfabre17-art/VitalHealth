namespace VitalHealth.Domain.Entities
{
    public class Doctor
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public int YearsOfExperience { get; private set; }
        public string Description { get; private set; } = string.Empty;

        private readonly List<Appointment> appointments = new();
        private readonly List<Specialty> specialties = new();
        public IReadOnlyCollection<Appointment> Appointments => appointments.AsReadOnly();
        public IReadOnlyCollection<Specialty> Specialties => specialties.AsReadOnly();

        protected Doctor() { }
        public Doctor(string name, int yearsOfExperience, string description) 
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("El nombre del doctor es invalido", nameof(name));
            }
            if(yearsOfExperience <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(YearsOfExperience), "Años de experiencia invalido");
            }

            Name = name.Trim();
            YearsOfExperience = yearsOfExperience;
            Description = description;
        }
        public void AddAppointment(Appointment appointment)
        {
            if(appointment == null)
                throw new ArgumentNullException(nameof(appointment));
            
            appointments.Add(appointment);
        }
        
        public void AddSpecialty (Specialty specialty)
        {
            if (specialty == null)
                throw new ArgumentNullException(nameof(specialty));

            specialties.Add(specialty);
        }
    }
}
