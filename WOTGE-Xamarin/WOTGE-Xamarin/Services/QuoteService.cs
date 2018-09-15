using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WOTGE_Xamarin.Services
{
    public class QuoteService : IQuoteService
    {
        private const string ServerAddress = "http://52.17.219.135:1994";
        private const string QuoteEndpoint = "api/Emperor/";

        private const string DefaultQuote = "Hope is the first step on the road to disappointment";

        private readonly HttpClient _httpClient;

        public QuoteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetQuoteAsync()
        {
            try
            {
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(new Uri(ServerAddress), QuoteEndpoint),
                    Method = HttpMethod.Get,
                };

                var response = await _httpClient.SendAsync(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var quoteString = await response.Content.ReadAsStringAsync();
                    return quoteString;
                }
                else
                {
                    return DefaultQuote;
                }
            }
            catch (Exception e)
            {
                // TODO: Show toast message
                throw e;
            }
        }

    }
}
