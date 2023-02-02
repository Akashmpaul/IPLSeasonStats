namespace IPLSeasonStats.Services.Contracts
{
    public interface IServiceManager
    {
        IMatchesService Matches { get; }

        //IDeliveriesService Deliveries { get; }
    }
}
