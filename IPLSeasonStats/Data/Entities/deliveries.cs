using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IPLSeasonStats.Data.Entities
{
    [Table("deliveries")]
    public class Deliveries
    {
        [Key]
        [Required(ErrorMessage = "match_id is required")]
       
        public int match_id { get; set; }

        [Required(ErrorMessage = "inning is required")]
        public int? inning { get; set; }

        [Required(ErrorMessage = "batting_team is required")]
        public string? batting_team { get; set; }

        [Required(ErrorMessage = "bowling_team is required")]
        public string? bowling_team { get; set; }

        [Required(ErrorMessage = "over is required")]
        public int? over { get; set; }

        [Required(ErrorMessage = "ball is required")]
        public int? ball { get; set; }

        [Required(ErrorMessage = "batsman is required")]
        public string? batsman { get; set; }

        [Required(ErrorMessage = "non_striker is required")]
        public string? non_striker { get; set; }

        [Required(ErrorMessage = "bowler is required")]
        public string? bowler { get; set; }

        [Required(ErrorMessage = "is_super_over is required")]
        public int? is_super_over { get; set; }

        [Required(ErrorMessage = "wide_runs is required")]
        public int? wide_runs { get; set; }

        [Required(ErrorMessage = "bye_runs is required")]
        public int? bye_runs { get; set; }

        [Required(ErrorMessage = "legbye_runs is required")]
        public int? legbye_runs { get; set; }

        [Required(ErrorMessage = "noball_runs is required")]
        public int? noball_runs { get; set; }

        [Required(ErrorMessage = "penalty_runs is required")]
        public int? penalty_runs { get; set; }

        [Required(ErrorMessage = "batsman_runs is required")]
        public int? batsman_runs { get; set; }

        [Required(ErrorMessage = "extra_runs is required")]
        public int? extra_runs { get; set; }

        [Required(ErrorMessage = "total_runs is required")]
        public int? total_runs { get; set; }

        [Required(ErrorMessage = "player_dismissed is required")]
        public string? player_dismissed { get; set; }

        [Required(ErrorMessage = "dismissal_kind is required")]
        public string? dismissal_kind { get; set; }

        [Required(ErrorMessage = "fielder is required")]
        public string? fielder { get; set; }
    }
}
