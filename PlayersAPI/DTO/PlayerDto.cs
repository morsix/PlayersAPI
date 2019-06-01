using System.ComponentModel.DataAnnotations;

namespace PlayersAPI.DTO
{
    public class PlayerDto
    {
        public string Guid { get; set; }

        public bool IsActive { get; set; }

        public string Picture { get; set; }

        [Key]
        public int Age { get; set; }

        public int YellowCards { get; set; }

        public int RedCards { get; set; }

        public int Goals { get; set; }

        public int Appearances { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public TeamDto Team { get; set; }

    }
}
