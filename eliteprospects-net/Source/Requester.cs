using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace eliteprospects_net
{
    internal class Requester
    {
        private readonly HttpClient httpClient;

        private string ApiKey { get; set; }

        internal Requester(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentException("API key cannot be null.");
            }

            httpClient = new HttpClient();
            ApiKey = key;
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

        public string BuildString(RequestType type, Parameters parameters, int id = -1)
        {
            string s = string.Empty;
            string typeString = ((RequestType)type).ToString().ToLower();
            if (string.IsNullOrWhiteSpace(parameters.Sort.ResultSort)) s = string.Format("{0}{1}?filter={2}&limit={3}&apiKey={4}", URL.BaseURL, typeString, parameters.Filter.SearchFilter, parameters.Limit.ResultLimit, ApiKey);
            else s = string.Format("{0}{1}?filter={2}&sort={3}&limit={4}&apiKey={5}", URL.BaseURL, typeString, parameters.Filter.SearchFilter, parameters.Sort.ResultSort, parameters.Limit.ResultLimit, ApiKey);
            return s;
        }
    }
}