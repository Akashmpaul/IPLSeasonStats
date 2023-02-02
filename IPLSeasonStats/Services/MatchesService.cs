using AutoMapper;
using IPLSeasonStats.Data.Entities;
using IPLSeasonStats.DTOs;
using IPLSeasonStats.Extensions.Exceptions;
using IPLSeasonStats.Extensions.Logger;
using IPLSeasonStats.Repository;
using IPLSeasonStats.Repository.Contracts;
using IPLSeasonStats.Services.Contracts;

namespace IPLSeasonStats.Services
{
    public class MatchesService : IMatchesService
    {
       private readonly IIPLSeasonStatsDBRepository _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public MatchesService(IIPLSeasonStatsDBRepository repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MatchesDto>> GetAllMatchesAsync()
        {
            var _matches = await _repository.matches.GetAllMatches();
            _logger.LogInfo($"Returned all matches information from database.");
            var _matchesResult = _mapper.Map<IEnumerable<MatchesDto>>(_matches);
            return _matchesResult;
        }
        public async Task<MatchesDto> GetMatchesByIdAsync(int id)
        {
            var matches = await _repository.matches.GetMatchesById(id);
            if (matches is null)
                throw new NotFoundException($"Match with id: {id} doesn't exist in the database.");

            var matchesResult = _mapper.Map<MatchesDto>(matches);
            _logger.LogInfo($"Returned requested Match information from database.");

            return matchesResult;
        }
        public async Task<IEnumerable<MatchDemo>> GetMatchInfoBySeasonAsync(int season)
        {
            var Matches = await _repository.matches.GetMatchInfoBySeason(season);
            if (Matches is null)
                throw new NotFoundException($"Match with id: {season} doesn't exist in the database.");

            //var matchesResult = _mapper.Map<IEnumerable<MatchesDto>>(Matches);
            //_logger.LogInfo($"Returned requested Match information from database.");

            return Matches;
        }

        public async Task<IEnumerable<MatchDemo>> GetTossWinnerBySeasonAsync(int season)
        {
            var Matches = await _repository.matches.GetTossWinnersBySeason(season);
            if (Matches is null)
                throw new NotFoundException($"Match with id: {season} doesn't exist in the database.");

            //var matchesResult = _mapper.Map<IEnumerable<MatchesDto>>(Matches);
            //_logger.LogInfo($"Returned requested Match information from database.");

            return Matches;
        }
        public async Task<IEnumerable<MatchDemo>> GetMostMatchWinnerBySeasonAsync(int season)
        {
            var Matches = await _repository.matches.GetMostMatchWinnerBySeason(season);
            if (Matches is null)
                throw new NotFoundException($"Match with id: {season} doesn't exist in the database.");

            //var matchesResult = _mapper.Map<IEnumerable<MatchesDto>>(Matches);
            //_logger.LogInfo($"Returned requested Match information from database.");

            return Matches;
        }
        public async Task<IEnumerable<MatchDemo>> GetPlayerofTheMatchBySeasonAsync(int season)
        {
            var Matches = await _repository.matches.GetPlayerofTheMatchBySeason(season);
            if (Matches is null)
                throw new NotFoundException($"Match with id: {season} doesn't exist in the database.");

            //var matchesResult = _mapper.Map<IEnumerable<MatchesDto>>(Matches);
            //_logger.LogInfo($"Returned requested Match information from database.");

            return Matches;
        }
        public async Task<MatchDemo> GetTeamWonByHighestMarginBySeasonAsync(int season)
        {
            var Matches = await _repository.matches.GetTeamWonByHighestMarginBySeason(season);
            if (Matches is null)
                throw new NotFoundException($"Match with id: {season} doesn't exist in the database.");

            //var matchesResult = _mapper.Map<MatchDemo>(Matches);
            var matchesResult = new MatchDemo()
            {
                TeamName = Matches.winner,
                WinByRun = Matches.win_by_runs
            };
            _logger.LogInfo($"Returned requested Match information from database.");

            //return _mapper.Map<MatchDemo>(matchesResult);
            return matchesResult;
        }

        public async Task<MatchDemo> GetTeamWonByHighestNoOfWicketBySeasonAsync(int season)
        {
            var Matches = await _repository.matches.GetTeamWonByHighestNoOfWicketBySeason(season);
            if (Matches is null)
                throw new NotFoundException($"Match with id: {season} doesn't exist in the database.");

            //var matchesResult = _mapper.Map<MatchDemo>(Matches);
            var matchesResult = new MatchDemo()
            {
                TeamName = Matches.winner,
                WinByWicket = Matches.win_by_wickets
            };
            _logger.LogInfo($"Returned requested Match information from database.");

            //return _mapper.Map<MatchDemo>(matchesResult);
            return matchesResult;
        }
        //public async Task<MatchDemo> GetTeamWinTossandMatchBySeasonAsync(int season)
        //{
        //    var Matches = await _repository.matches.GetTeamWinTossandMatchBySeason(season);
        //    if (Matches is null)
        //        throw new NotFoundException($"Match with id: {season} doesn't exist in the database.");

        //    //var matchesResult = _mapper.Map<MatchDemo>(Matches);
        //    var matchesResult = new MatchDemo()
        //    {
        //        TeamName = Matches.winner,
        //        Wins = Matches.toss_winner
        //    };
        //    _logger.LogInfo($"Returned requested Match information from database.");

        //    //return _mapper.Map<MatchDemo>(matchesResult);
        //    return matchesResult;
        //}
        //public async Task<MatchDemo> GetLocationHostNoOfMatchesBySeasonAsync(int season)
        //{
        //    var Matches = await _repository.matches.GetLocationHostNoOfMatchesBySeason(season);
        //    if (Matches is null)
        //        throw new NotFoundException($"Match with id: {season} doesn't exist in the database.");

        //    //var matchesResult = _mapper.Map<MatchDemo>(Matches);
        //    var matchesResult = new MatchDemo()
        //    {
        //        CityName = Matches.city,
        //        MatchHosted = Matches
        //    };
        //    _logger.LogInfo($"Returned requested Match information from database.");

        //    //return _mapper.Map<MatchDemo>(matchesResult);
        //    return matchesResult;
        //}
    }
   

}
