using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Travelogue03.Models;

namespace Travelogue03.Data
{
    public class Travelogue03Context : DbContext
    {
        public Travelogue03Context (DbContextOptions<Travelogue03Context> options)
            : base(options)
        {
        }

        public DbSet<Travelogue03.Models.TravelDetails> TravelDetails { get; set; } = default!;
    }
}
