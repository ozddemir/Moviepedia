using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moviepedia.Models.ORM.Contexts
{
    public class MovipediaContext : DbContext
    {
        public MovipediaContext(DbContextOptions<MovipediaContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Crew> Crews { get; set; }
        public DbSet<Cast> Casts { get; set; }

    }
}
