using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileProject.Models.GameSystemModels
{
    public class GameSystemDetails
    {
        public int ID { get; set; }
        public string SystemName { get; set; }
        public DateTimeOffset SystemNameCreated { get; set; }
        public DateTimeOffset? SystemNameUpdated { get; set; }
    }
}