using Microsoft.EntityFrameworkCore;

namespace IPLSeasonStats.Data
{
    public class IPLSeasonStatsDBContext : DbContext
    {
        public IPLSeasonStatsDBContext(DbContextOptions<IPLSeasonStatsDBContext> options) : base(options)
        {

        }
        public virtual DbSet<Entities.Matches> Matches { get; set; }
      //  public virtual DbSet<Entities.Deliveries> Deliveries { get; set; }
    }
}
