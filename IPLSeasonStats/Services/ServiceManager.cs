using AutoMapper;
using IPLSeasonStats.Extensions.Logger;
using IPLSeasonStats.Repository.Contracts;
using IPLSeasonStats.Services.Contracts;

namespace IPLSeasonStats.Services
{
    public class ServiceManager : IServiceManager
    {
        private Lazy<IMatchesService> _matchesService;
        //private Lazy<IDeliveriesService> _deliveriesService;

        public IMatchesService Matches
        {
            get
            {
                return _matchesService.Value;
            }
        }

        //public IDeliveriesService Deliveries
        //{
        //    get
        //    {
        //        return _deliveriesService.Value;
        //    }
        //}
        public ServiceManager(IIPLSeasonStatsDBRepository repository, ILoggerManager logger, IMapper mapper, IConfiguration configuration)
        {
            _matchesService = new Lazy<IMatchesService>(() => new MatchesService(repository, logger, mapper));
          //  _deliveriesService = new Lazy<IDeliveriesService>(() => new DeliveriesService(repository, logger, mapper));
           
        }
    }
}
