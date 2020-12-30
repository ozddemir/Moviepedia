using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Moviepedia.Models.ORM
{
    public class Movie:Base
    {
        [Required]
        public string Name { get; set; }
        public string Storyline { get; set; }
        public string Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Cast> Casts { get; set; }
        public List<Crew> TheCrew { get; set; }

    }
}
