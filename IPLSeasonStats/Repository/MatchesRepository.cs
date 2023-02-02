using IPLSeasonStats.Data;
using IPLSeasonStats.Data.Entities;
using IPLSeasonStats.DTOs;
using IPLSeasonStats.Extensions.Exceptions;
using IPLSeasonStats.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


namespace IPLSeasonStats.Repository
{
    public class MatchesRepository : RepositoryBase<Matches>,IMatchesRepository
    {
        public MatchesRepository(IPLSeasonStatsDBContext repositoryContext)
        : base(repositoryContext)
        {
        }
        public async Task<IEnumerable<Matches>> GetAllMatches()
        {
            
            return await FindAll()
               .OrderBy(o => o.id)
                .ToListAsync();
        }
        public async Task<Matches> GetMatchesById(int id)
        {
            var Matches = await FindByCondition(Matches => Matches.id.Equals(id))
                .FirstOrDefaultAsync();
            if (Matches == null)
            {
                throw new NotFoundException($"There is no such matches exists in our database with Id {id}");
            }
            return Matches;
        }
        //public async Task<Matches> GetMatchInfoBySeason(int season)
        //{
        //    var Matches = await FindByCondition(Matches => Matches.season.Equals(season))
        //        .FirstOrDefaultAsync();
        //    if (Matches == null)
        //    {
        //        throw new NotFoundException($"There is no such matches exists in our database with Id {season}");
        //    }
        //    return Matches;
        //}
        public async Task<IEnumerable<MatchDemo>> GetMatchInfoBySeason(int season)
        {
            var Matches = await FindByCondition(Matches => Matches.season.Equals(season))
               .GroupBy(o => o.winner)
                .Select(
                    g => new MatchDemo
                    {
                        TeamName = g.Key,
                        Wins = g.Count()
                    }).OrderByDescending(o => o.Wins)
                .ToListAsync();
                //.Select(g => new { Team = g.Key, Wins = g.Count(x => x.winner)});
            if (Matches == null)
            {
                throw new NotFoundException($"There is no such matches exists in our database with Id {season}");
            }
            return Matches.Take(4);
               
        }

        public async Task<IEnumerable<MatchDemo>> GetTossWinnersBySeason(int season)
        {
            var Matches = await FindByCondition(Matches => Matches.season.Equals(season))
               .GroupBy(o => o.toss_winner)
                .Select(
                    g => new MatchDemo
                    {
                        TeamName = g.Key,
                        Wins = g.Count()
                    }).OrderByDescending(o => o.Wins)
                .ToListAsync();
            //.Select(g => new { Team = g.Key, Wins = g.Count(x => x.winner)});
            if (Matches == null)
            {
                throw new NotFoundException($"There is no such matches exists in our database with Id {season}");
            }
            return Matches.Take(1);

        }

        public async Task<IEnumerable<MatchDemo>> GetMostMatchWinnerBySeason(int season)
        {
            var Matches = await FindByCondition(Matches => Matches.season.Equals(season))
               .GroupBy(o => o.winner)
                .Select(
                    g => new MatchDemo
                    {
                        TeamName = g.Key,
                        Wins = g.Count()
                    }).OrderByDescending(o => o.Wins)
                .ToListAsync();
            //.Select(g => new { Team = g.Key, Wins = g.Count(x => x.winner)});
            if (Matches == null)
            {
                throw new NotFoundException($"There is no such matches exists in our database with Id {season}");
            }
            return Matches.Take(1);

        }

        public async Task<IEnumerable<MatchDemo>> GetPlayerofTheMatchBySeason(int season)
        {
            var Matches = await FindByCondition(Matches => Matches.season.Equals(season))
               .GroupBy(o => o.player_of_match)
                .Select(
                    g => new MatchDemo
                    {
                        PlayerName = g.Key,
                        Wins = g.Count()
                    }).OrderByDescending(o => o.Wins)
                .ToListAsync();
            //.Select(g => new { Team = g.Key, Wins = g.Count(x => x.winner)});
            if (Matches == null)
            {
                throw new NotFoundException($"There is no such matches exists in our database with Id {season}");
            }
            return Matches.Take(1);

        }
        public async Task<Matches> GetTeamWonByHighestMarginBySeason(int season)
        {
            var Matches = await FindByCondition(Matches => Matches.season.Equals(season))
              .OrderByDescending(o => o.win_by_runs)
          .FirstOrDefaultAsync();
           



            //.Select(g => new { Team = g.Key, Wins = g.Count(x => x.winner)});
            if (Matches == null)
            {
                throw new NotFoundException($"There is no such matches exists in our database with Id {season}");
            }
            return Matches;

        }

        public async Task<Matches> GetTeamWonByHighestNoOfWicketBySeason(int season)
        {
            var Matches = await FindByCondition(Matches => Matches.season.Equals(season))
              .OrderByDescending(o => o.win_by_wickets)
          .FirstOrDefaultAsync();

            //.Select(g => new { Team = g.Key, Wins = g.Count(x => x.winner)});
            if (Matches == null)
            {
                throw new NotFoundException($"There is no such matches exists in our database with Id {season}");
            }
            return Matches;

        }
        //public async Task<Matches> GetTeamWinTossandMatchBySeason(int season)
        //{
        //    var Matches = await FindByCondition(Matches => Matches.season.Equals(season))
        //      .OrderByDescending(o => o.toss_winner)
        //  .FirstOrDefaultAsync();

        //    //.Select(g => new { Team = g.Key, Wins = g.Count(x => x.winner)});
        //    if (Matches == null)
        //    {
        //        throw new NotFoundException($"There is no such matches exists in our database with Id {season}");
        //    }
        //    return Matches;

        //}
        //public async Task<Matches> GetLocationHostNoOfMatchesBySeason(int season)
        //{
        //    var Matches = await FindByCondition(Matches => Matches.season.Equals(season))
        //     .OrderByDescending(o => o.id)
        //  .FirstOrDefaultAsync();

        //    //.Select(g => new { Team = g.Key, Wins = g.Count(x => x.winner)});
        //    if (Matches == null)
        //    {
        //        throw new NotFoundException($"There is no such matches exists in our database with Id {season}");
        //    }
        //    return Matches;

        //}
    }
}
