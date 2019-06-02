using System;
using System.ComponentModel.DataAnnotations;

namespace PlayersAPI.Models
{
    public class Player
    {
        [Key]
        public Guid Guid { get; set; }

        public bool IsActive { get; set; }

        public string Picture { get; set; }
        
        public int Age { get; set; }

        public int YellowCards { get; set; }

        public int RedCards { get; set; }

        public int Goals { get; set; }

        public int Appearances { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public Team Team { get; set; }
    }
}
