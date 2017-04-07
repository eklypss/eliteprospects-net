using eliteprospects_net.Source.Data;
using eliteprospects_net.Source.Enum;
using eliteprospects_net.Source.Model.Parameters;
using System.Net.Http;
using System.Threading.Tasks;

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

        public async Task<string> GetResultAsync(HttpRequestMessage requestMessage)
        {
            var result = string.Empty;
            using (var response = await httpClient.GetAsync(requestMessage.RequestUri))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException();
                }
                using (var content = response.Content)
                {
                    result = await content.ReadAsStringAsync();
                }
            }
            return result;
        }

        public string BuildString(RequestType type, Parameters parameters)
        {
            string typeString = ((RequestType)type).ToString().ToLower();
            string s = string.Empty;
            if (string.IsNullOrWhiteSpace(parameters.Sort.ResultSort)) s = string.Format("{0}{1}?filter={2}&limit={3}", URL.BaseURL, typeString, parameters.Filter.SearchFilter, parameters.Limit.ResultLimit);
            else s = string.Format("{0}{1}?filter={2}&sort={3}&limit={4}", URL.BaseURL, typeString, parameters.Filter.SearchFilter, parameters.Sort.ResultSort, parameters.Limit.ResultLimit);
            return s;
        }
    }
}