using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Sirius.Models
{
    public class SiriusContext : DbContext
    {
        public SiriusContext(DbContextOptions<SiriusContext> options)
           : base(options)
        {
        }

        public DbSet<Dispositivo> Dispositivo { get; set; }
        public DbSet<DettagliDispositivo> DettagliDispositivo { get; set; }
    }
}
