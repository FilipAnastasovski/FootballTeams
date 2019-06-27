using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Football.Models
{
    public class Match
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }

        public int GuestTeamId { get; set; }
        public Team GuestTeam { get; set; }

        public string Score { get; set; }

    }
}
