using eliteprospects_net.Source.Data;
using eliteprospects_net.Source.Enum;
using eliteprospects_net.Source.Model.Parameters;
using System.Net.Http;

namespace eliteprospects_net.Source
{
    internal class Requester
    {
        private readonly HttpClient httpClient;

        internal Requester()
        {
            httpClient = new HttpClient();
        }

        public string GetResult(HttpRequestMessage requestMessage)
        {
            var result = string.Empty;
            using (var response = httpClient.GetAsync(requestMessage.RequestUri).Result)
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException();
                }
                using (var content = response.Content)
                {
                    result = content.ReadAsStringAsync().Result;
                }
            }
            return result;
        }

        public string BuildString(RequestType type, Parameters parameters)
        {
            string result = string.Empty;
            switch (type)
            {
                case RequestType.RetiredNumbers:
                {
                    return string.Format("{0}{1}?filter={2}&limit={3}", URL.BaseURL, URL.RetiredNumbersURL, parameters.Filter.SearchFilter, parameters.Limit.ResultLimit);
                }
            }
            return result;
        }
    }
}