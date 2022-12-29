using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AgileProject.Data.Entities
{
    public class GameSystemEntity
    {
        public int Id { get; set; }
        public string SystemName { get; set; }
    }
}