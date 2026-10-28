using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using VitalHealth.Domain.Entities;

namespace VitalHealth.Application
{
    public interface IApplicationDbContext
    {
        DbSet<Appointment> Appointments { get; }
    }
}
