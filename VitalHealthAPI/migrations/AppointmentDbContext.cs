using Microsoft.EntityFrameworkCore;
using VitalHealthAPI.Entities;
namespace VitalHealthAPI.migrations
{
    public class AppointmentDbContext : DbContext
    {
        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<Doctor> Doctors => Set<Doctor>();
        public DbSet<Appointment> Appointments => Set<Appointment>();
        public DbSet<Specialty> Specialties => Set<Specialty>();

        public AppointmentDbContext(DbContextOptions<AppointmentDbContext> options) 
            : base(options) { }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Doctor>()
            .HasMany(s => s.Specialties)
            .WithMany(d => d.Doctors);
        }
    
    }
}
