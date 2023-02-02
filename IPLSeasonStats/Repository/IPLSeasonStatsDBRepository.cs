using IPLSeasonStats.Data;
using IPLSeasonStats.Repository.Contracts;

namespace IPLSeasonStats.Repository
{
    public class IPLSeasonStatsDBRepository : IIPLSeasonStatsDBRepository
    {
        private IPLSeasonStatsDBContext _statsDBcontext;
        private Lazy<IMatchesRepository> _matchesRepo;


        // private Lazy<IDeliveriesRepository> _deliveriesRepo;
        public IMatchesRepository matches
        {
            get
            {
                return _matchesRepo.Value;
            }
        }

        //public IDeliveriesRepository deliveries
        //{
        //    get
        //    {
        //        return _deliveriesRepo.Value;
        //    }
        //}

        public IPLSeasonStatsDBRepository(IPLSeasonStatsDBContext repositoryContext)
        {
            _statsDBcontext = repositoryContext;
            _matchesRepo = new Lazy<IMatchesRepository>(() => new MatchesRepository(repositoryContext));
           // _deliveriesRepo = new Lazy<IDeliveriesRepository>(() => new DeliveriesRepository(repositoryContext));
        }

    }
}
