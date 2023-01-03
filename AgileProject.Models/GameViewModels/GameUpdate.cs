using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AgileProject.Models.GameViewModels
{
    public class GameUpdate
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "{0} must be at least {1} characters long.")]
        [MaxLength(200, ErrorMessage = "{0} must be less than {1} characters long.")]
        public string Title { get; set; }
        // public GameSystemEntity GameSystem { get; set; }
        // public GenreEntity GameGenre { get; set; }
    }
}