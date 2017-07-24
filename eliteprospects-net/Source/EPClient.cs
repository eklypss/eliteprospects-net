using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace eliteprospects_net
{
    public class EPClient : IEPClient
    {
        private readonly Requester requester;

        public EPClient(string key)
        {
            requester = new Requester(key);
        }

        public RetiredNumber GetRetiredNumber(Parameters parameters)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, requester.BuildString(RequestType.Transfers, parameters)))
            {
                var result = requester.GetResult(request);
                return JsonConvert.DeserializeObject<RetiredNumber>(result);
            }
        }

        public async Task<RetiredNumber> GetRetiredNumberAsync(Parameters parameters)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, requester.BuildString(RequestType.Transfers, parameters)))
            {
                var result = await requester.GetResultAsync(request);
                return JsonConvert.DeserializeObject<RetiredNumber>(result);
            }
        }

        public Transfer GetTransfer(Parameters parameters)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, requester.BuildString(RequestType.Transfers, parameters)))
            {
                var result = requester.GetResult(request);
                return JsonConvert.DeserializeObject<Transfer>(result);
            }
        }

        public async Task<Transfer> GetTransferAsync(Parameters parameters)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, requester.BuildString(RequestType.Transfers, parameters)))
            {
                var result = await requester.GetResultAsync(request);
                return JsonConvert.DeserializeObject<Transfer>(result);
            }
        }

        public PlayerStatisticalData GetStatisticalData(Parameters parameters)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, requester.BuildString(RequestType.Transfers, parameters)))
            {
                var result = requester.GetResult(request);
                return JsonConvert.DeserializeObject<PlayerStatisticalData>(result);
            }
        }

        public async Task<PlayerStatisticalData> GetStatisticalDataAsync(Parameters parameters)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, requester.BuildString(RequestType.Transfers, parameters)))
            {
                var result = await requester.GetResultAsync(request);
                return JsonConvert.DeserializeObject<PlayerStatisticalData>(result);
            }
        }
    }
}