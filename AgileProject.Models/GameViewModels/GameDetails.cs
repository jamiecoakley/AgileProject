using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileProject.Models.GameViewModels
{
    public class GameDetails
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}