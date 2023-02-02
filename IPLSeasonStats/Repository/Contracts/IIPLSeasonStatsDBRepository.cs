namespace IPLSeasonStats.Repository.Contracts
{
    public interface IIPLSeasonStatsDBRepository
    {
        IMatchesRepository matches { get; }
       // IDeliveriesRepository deliveries { get; }
    }
}
