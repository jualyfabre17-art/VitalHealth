using System.Security.Cryptography.X509Certificates;

namespace VitalHealth.Domain.Entities
{
    public class Patient
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public int Age { get; private set; }
        public string Sex { get; private set; } = string.Empty;

        private readonly List<Appointment> appointments = new();
        public IReadOnlyCollection<Appointment> Appointments => appointments.AsReadOnly(); 

        protected Patient () { }

        public Patient(string name, int age, string sex)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("El nombre es invalido", nameof(name));
            }
            if(age <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(age),"La edad es invalida");
            }
            if (string.IsNullOrWhiteSpace(sex))
            {
                throw new ArgumentException("El sexo es invalido", nameof(sex));
            }

            Name = name.Trim();
            Age = age;
            Sex = sex.Trim();
        }
        public void AddAppointment(Appointment appointment) 
        { 
            if (appointment == null)
                throw new ArgumentNullException(nameof(appointment));
            
            appointments.Add(appointment);
        }
    }
}
