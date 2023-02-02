namespace IPLSeasonStats.DTOs
{
    public class MatchesDto
    {
        virtual public int id { get; set; }
        virtual public int? season { get; set; }
        virtual public string? city { get; set; }
        virtual public string? date { get; set; }
        virtual public string? team1 { get; set; }
        virtual public string? team2 { get; set; }
        virtual public string? toss_winner { get; set; }
        virtual public string? toss_decision { get; set; }
        virtual public string? result { get; set; }
        virtual public int? dl_applied { get; set; }
        virtual public string? winner { get; set; }
        virtual public int? win_by_runs { get; set; }
        virtual public int? win_by_wickets { get; set; }
        virtual public string? player_of_match { get; set; }
        virtual public string? venue { get; set; }
        virtual public string? umpire1 { get; set; }
        virtual public string? umpire2 { get; set; }
        virtual public string? umpire3 { get; set; }
    }
}
