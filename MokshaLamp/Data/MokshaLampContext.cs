using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MokshaLamp.Models;

namespace MokshaLamp.Data
{
    public class MokshaLampContext : DbContext
    {
        public MokshaLampContext(DbContextOptions<MokshaLampContext> options)
            : base(options)
        {
        }

        public DbSet<Lamp> Lamp { get; set; }
    }
}
