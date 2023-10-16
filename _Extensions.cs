namespace keep_track_of_your_page_visits_in_blazor_server
{
    public static class _Extensions
    {
        public static string Header(this HttpRequest httpRequest, string header)
        {
            return httpRequest.Headers.ContainsKey(header) ? httpRequest.Headers[header].ToString() : string.Empty;
        }
    }
}
