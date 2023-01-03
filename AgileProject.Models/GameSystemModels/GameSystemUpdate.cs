using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AgileProject.Models.GameSystemModels
{
    public class GameSystemUpdate
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "{0} must be at least {1} characters long.")]
        [MaxLength(100, ErrorMessage = "{0} must contain no more than {1} characters.")]
        public string SystemName { get; set; }
    }
}