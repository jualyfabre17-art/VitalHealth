namespace VitalHealthAPI.Entities
{
    public class Specialty
    {
        public int Id { get; set; }
        public string SpecialtyType { get; set; } = string.Empty;

        public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
    }
}
