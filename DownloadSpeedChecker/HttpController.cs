using System.Net.Http;

namespace DownloadSpeedChecker
{
    class HttpController
    {
        private static readonly HttpClient client;
        static HttpController()
        {
            client = new HttpClient();

            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text / html, application / xhtml + xml, application / xml");
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:19.0) Gecko/20100101 Firefox/19.0");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip, deflate, br");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "en-GB");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Host", "www.google.com");
        }

    public HttpClient HttpClient()
        {
            return client;
        }
    }
}
