using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Football.Models
{
    public class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  int Id { get; set; }

        public  string FirstName { get; set; }
       
        public int DressNum { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }

    }
}
