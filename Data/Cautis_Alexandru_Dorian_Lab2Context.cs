using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cautis_Alexandru_Dorian_Lab2.Models;

namespace Cautis_Alexandru_Dorian_Lab2.Data
{
    public class Cautis_Alexandru_Dorian_Lab2Context : DbContext
    {
        public Cautis_Alexandru_Dorian_Lab2Context (DbContextOptions<Cautis_Alexandru_Dorian_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Cautis_Alexandru_Dorian_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Cautis_Alexandru_Dorian_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
