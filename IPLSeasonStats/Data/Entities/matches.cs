using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IPLSeasonStats.Data.Entities
{
    [Table("matches")]
    public class Matches
    {
        [Key]
        [Required(ErrorMessage = "id is required")]
        public int id { get; set; }

        [Required(ErrorMessage = "season is required")]
        public int? season { get; set; }

        [Required(ErrorMessage = "city is required")]
        public string? city { get; set; }

        [Required(ErrorMessage = "date is required")]
        public string? date { get; set; }

        [Required(ErrorMessage = "team1 is required")]
        public string? team1 { get; set; }

        [Required(ErrorMessage = "team2 is required")]
        public string? team2 { get; set; }

        [Required(ErrorMessage = "toss_winner is required")]
        public string? toss_winner { get; set; }

        [Required(ErrorMessage = "toss_decision is required")]
        public string? toss_decision { get; set; }

        [Required(ErrorMessage = "result is required")]
        public string? result { get; set; }

        [Required(ErrorMessage = "dl_aplied is required")]
        public int? dl_applied { get; set; }

        [Required(ErrorMessage = "winner is required")]
        public string? winner { get; set; }

        [Required(ErrorMessage = "win_by_runs is required")]
        public int? win_by_runs { get; set; }

        [Required(ErrorMessage = "win_by_wickets is required")]
        public int? win_by_wickets { get; set; }

        [Required(ErrorMessage = "player_of_match is required")]
        public string? player_of_match { get; set; }

        [Required(ErrorMessage = "venue is required")]
        public string? venue { get; set; }
        
        [Required(ErrorMessage = "umpire1 is required")]
        public string? umpire1 { get; set; }

        [Required(ErrorMessage = "umpire2 is required")]
        public string? umpire2 { get; set; }

        [Required(ErrorMessage = "umpire3 is required")]
        public string? umpire3 { get; set; }
    }

}
