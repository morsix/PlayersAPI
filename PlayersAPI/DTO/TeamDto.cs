using System.ComponentModel.DataAnnotations;

namespace PlayersAPI.DTO
{
    public class TeamDto
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
