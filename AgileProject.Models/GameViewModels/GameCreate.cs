using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace AgileProject.Models.GameViewModels
{
    public class GameCreate
    {
        [Required]
        [MinLength(1, ErrorMessage ="{0} must be at least {1} characters long.")]
        [MaxLength(200, ErrorMessage ="{0} must be no more than {1} characters.")]
        public string Title { get; set; }
    //     public GameSystemEntity GameSystem { get; set; }
    //     public GenreEntity GameGenre { get; set; }
    }
}