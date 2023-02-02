namespace IPLSeasonStats.DTOs
{
    public class DeliveriesDto
    {
        public int match_id { get; set; }
        public int? inning { get; set; }
        public string? batting_team { get; set; }
        public string? bowling_team { get; set; }
        public int? over { get; set; }
        public int? ball { get; set; }
        public string? batsman { get; set; }
        public string? non_striker { get; set; }
        public string? bowler { get; set; }
        public int? is_super_over { get; set; }
        public int? wide_runs { get; set; }
        public int? bye_runs { get; set; }
        public int? legbye_runs { get; set; }
        public int? noball_runs { get; set; }
        public int? penalty_runs { get; set; }
        public int? batsman_runs { get; set; }
        public int? extra_runs { get; set; }
        public int? total_runs { get; set; }
        public string? player_dismissed { get; set; }
        public string? dismissal_kind { get; set; }
        public string? fielder { get; set; }
    }
}
