namespace IPLSeasonStats.DTOs
{
    public class MatchDemo
    {
        virtual public string TeamName { get; set; }
        virtual public int Wins { get; set; }
        virtual public string PlayerName { get; set; }
        virtual public int? WinByRun { get; set; }
        virtual public int? WinByWicket { get; set; }
        virtual public string CityName { get; set; }
        virtual public string MatchHosted { get; set; }
    }
}
