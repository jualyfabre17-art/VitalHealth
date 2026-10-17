namespace VitalHealthAPI.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>(); 
    }
}
