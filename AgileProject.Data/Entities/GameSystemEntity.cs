using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AgileProject.Data.Entities
{
    public class GameSystemEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string SystemName { get; set; }

        [Required]
        public DateTimeOffset SystemNameCreated { get; set; }
        public DateTimeOffset? SystemNameUpdated { get; set; }
    }
}