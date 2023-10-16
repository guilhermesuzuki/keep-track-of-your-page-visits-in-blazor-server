using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace keep_track_of_your_page_visits_in_blazor_server.Models
{
    [Table("PageVisits")]
    public class PageVisit
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string UserAgent { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string UrlReferrer { get; set; } = string.Empty;
        public string RemoteIpAddress { get; set; } = string.Empty;
    }
}
