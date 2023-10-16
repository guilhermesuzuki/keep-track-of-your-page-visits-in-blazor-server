using keep_track_of_your_page_visits_in_blazor_server.Data;
using Microsoft.AspNetCore.Mvc;

namespace keep_track_of_your_page_visits_in_blazor_server.Controllers
{
    [Route("[Controller]")]
    public class ViewsController : Controller
    {
        private readonly TrackContext _trackContext;

        public ViewsController(TrackContext trackContext): base()
        {
            this._trackContext = trackContext;
        }

        [HttpGet]
        public IActionResult Index([FromQuery] string href, [FromQuery] string referrer)
        {
            var pagevisit = new Models.PageVisit
            {
                UserAgent = this.Request.Header("User-Agent"),
                Url = href,
                UrlReferrer = referrer ?? string.Empty,
                RemoteIpAddress = this.HttpContext.Connection.RemoteIpAddress?.ToString() ?? "::1",
            };

            this._trackContext.Add(pagevisit);
            this._trackContext.SaveChanges();

            return Ok();
        }

        
    }
}
