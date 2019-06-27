using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Football.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }

    }
}
