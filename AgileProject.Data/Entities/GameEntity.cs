using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgileProject.Data.Entities
{
    public class GameEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        //[ForeignKey(nameof(GameSystem))]
        //public GameSystemEntity GameSystem { get; set; }

        //[Required]
        //public GenreEntity GameGenre {get;set;}

        //[ForeignKey(nameof(Owner))]
        //public int OwnerId{get;set;}
        //public UserEntity Owner{get;set;}
    }
}