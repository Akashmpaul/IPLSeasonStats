using IPLSeasonStats.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace IPLSeasonStats.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class MatchesController : ControllerBase
    {
       private readonly IServiceManager _service;

       public MatchesController(IServiceManager services)
        {
            _service = services;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMatches()
        {
            var MatchesResult = await _service.Matches.GetAllMatchesAsync();
            return Ok(MatchesResult);
        }
        [HttpGet("TopFourTeams/{id}", Name = "MatchesById")]
        public async Task<IActionResult> GetMatchesById(int id)
        {
            var matchesResult = await _service.Matches.GetMatchesByIdAsync(id);
            return Ok(matchesResult);
        }
        [HttpGet("TopFourWins/{season}", Name = "MatchInfoBySeason")]
        public async Task<IActionResult> GetMatchInfoBySeason(int season)
        {
            var matchesResult = await _service.Matches.GetMatchInfoBySeasonAsync(season);
            return Ok(matchesResult);
        }
        [HttpGet("TossWinners/{season}", Name = "TossWinnersBySeason")]
        public async Task<IActionResult> GetTossWinnerBySeason(int season)
        {
            var matchesResult = await _service.Matches.GetTossWinnerBySeasonAsync(season);
            return Ok(matchesResult);
        }
        [HttpGet("MostMatchWinners/{season}", Name = "MostMatchWinnersBySeason")]
        public async Task<IActionResult> GetMostMatchWinnerBySeason(int season)
        {
            var matchesResult = await _service.Matches.GetMostMatchWinnerBySeasonAsync(season);
            return Ok(matchesResult);
        }
        [HttpGet("PlayerofTheMatch/{season}", Name = "PlayerofMatchBySeason")]
        public async Task<IActionResult> GetPlayerofMatchBySeason(int season)
        {
            var matchesResult = await _service.Matches.GetPlayerofTheMatchBySeasonAsync(season);
            return Ok(matchesResult);
        }
        [HttpGet("TeamWonByHighestMargin/{season}", Name = "TeamWonByHighestMarginBySeason")]
        public async Task<IActionResult> GetTeamWonByHighestMarginBySeason(int season)
        {
            var matchesResult = await _service.Matches.GetTeamWonByHighestMarginBySeasonAsync(season);
            return Ok(matchesResult);
        }
        [HttpGet("TeamWonByHighestWicket/{season}", Name = "TeamWonByHighestWicketBySeason")]
        public async Task<IActionResult> GetTeamWonByHighestWicketBySeason(int season)
        {
            var matchesResult = await _service.Matches.GetTeamWonByHighestNoOfWicketBySeasonAsync(season);
            return Ok(matchesResult);
        }
    }

}
