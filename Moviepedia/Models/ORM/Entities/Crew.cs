using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Moviepedia.Models.ORM
{
    public class Crew:Base
    {
        [Required]
        public string Fullname { get; set; }
        public string title { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
