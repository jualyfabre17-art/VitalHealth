namespace VitalHealthAPI.Entities
{
    public class Specialty
    {
        public int Id { get; private set; }
        public string SpecialtyType { get; private set; } = string.Empty;
        public int Members {  get; private set; }

        private readonly List<Doctor> doctors = new();
        public IReadOnlyCollection<Doctor> Doctors => doctors.AsReadOnly();

        protected Specialty() { }

        public Specialty(string specialtyType, int members)
        {
            if (string.IsNullOrWhiteSpace(specialtyType))
            {
                throw new ArgumentException("Tipo de especialidad invalido", nameof(specialtyType));
            }
            if(members <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(members), "Rango de miembros de especialidad invalido");
            }

            SpecialtyType = specialtyType;
            Members = members;
        }

        public void AddDoctor(Doctor doctor)
        {
            if(doctor == null)
                throw new ArgumentNullException(nameof(doctor));
            
            doctors.Add(doctor);
        }
    }
}
