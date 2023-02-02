using IPLSeasonStats.Data.Entities;
using IPLSeasonStats.DTOs;

namespace IPLSeasonStats.Repository.Contracts
{
    public interface IMatchesRepository : IRepositoryBase<Matches>
    {
        Task<IEnumerable<Matches>> GetAllMatches();
        Task<Matches> GetMatchesById(int id);
        Task<IEnumerable<MatchDemo>> GetMatchInfoBySeason(int season);
        Task<IEnumerable<MatchDemo>> GetTossWinnersBySeason(int season);
        Task<IEnumerable<MatchDemo>> GetMostMatchWinnerBySeason(int season);
        Task<IEnumerable<MatchDemo>> GetPlayerofTheMatchBySeason(int season);
        Task<Matches> GetTeamWonByHighestMarginBySeason(int season);
        Task<Matches> GetTeamWonByHighestNoOfWicketBySeason(int season);
       // Task<Matches> GetLocationHostNoOfMatchesBySeason(int season);
        //  Task<Matches> GetTeamWinTossandMatchBySeason(int season);
    }
}
