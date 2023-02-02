using IPLSeasonStats.DTOs;

namespace IPLSeasonStats.Services.Contracts
{
    public interface IMatchesService
    {
        Task<IEnumerable<MatchesDto>> GetAllMatchesAsync();
        Task<MatchesDto> GetMatchesByIdAsync(int id);
        Task<IEnumerable<MatchDemo>> GetMatchInfoBySeasonAsync(int season);
        Task<IEnumerable<MatchDemo>> GetTossWinnerBySeasonAsync(int season);
        Task<IEnumerable<MatchDemo>> GetMostMatchWinnerBySeasonAsync(int season);
        Task<IEnumerable<MatchDemo>> GetPlayerofTheMatchBySeasonAsync(int season);
        Task<MatchDemo> GetTeamWonByHighestMarginBySeasonAsync(int season);
        Task<MatchDemo> GetTeamWonByHighestNoOfWicketBySeasonAsync(int season);
       // Task<MatchDemo> GetLocationHostNoOfMatchesBySeasonAsync(int season);
        //  Task<MatchDemo> GetTeamWinTossandMatchBySeasonAsync(int season);
    }
}
