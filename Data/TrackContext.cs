using Microsoft.EntityFrameworkCore;

namespace keep_track_of_your_page_visits_in_blazor_server.Data
{
    public class TrackContext: DbContext
    {
        /// <summary>
        /// Default constructor with DI
        /// </summary>
        /// <param name="contextOptions"></param>
        public TrackContext(DbContextOptions<TrackContext> contextOptions) : base(contextOptions)
        {
            Database.EnsureCreated();
            Database.OpenConnection();
        }

        public DbSet<Models.PageVisit> PageVisits { get; set; }
    }
}
