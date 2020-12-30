using Moviepedia.Models.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Moviepedia.Models
{
    public class Cast: Base
    {
        [Required]
        public string Fullname { get; set; }

        public DateTime BirthDate { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
