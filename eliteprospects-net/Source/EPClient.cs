using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace eliteprospects_net
{
    public class EPClient : IEPClient
    {
        private static EPClient instance;
        private Requester requester;

        public static EPClient GetInstance()
        {
            if (instance == null)
            {
                instance = new EPClient();
            }
            return instance;
        }

        public EPClient()
        {
            requester = new Requester();
        }

        public RetiredNumber GetRetiredNumber(Parameters parameters)
        {
            var result = requester.GetResult(new HttpRequestMessage(HttpMethod.Get, requester.BuildString(RequestType.RetiredNumbers, parameters)));
            return JsonConvert.DeserializeObject<RetiredNumber>(result);
        }

        public async Task<RetiredNumber> GetRetiredNumberAsync(Parameters parameters)
        {
            var result = await requester.GetResultAsync(new HttpRequestMessage(HttpMethod.Get, requester.BuildString(RequestType.RetiredNumbers, parameters)));
            return JsonConvert.DeserializeObject<RetiredNumber>(result);
        }

        public Transfer GetTransfer(Parameters parameters)
        {
            var result = requester.GetResult(new HttpRequestMessage(HttpMethod.Get, requester.BuildString(RequestType.Transfers, parameters)));
            return JsonConvert.DeserializeObject<Transfer>(result);
        }

        public async Task<Transfer> GetTransferAsync(Parameters parameters)
        {
            var result = await requester.GetResultAsync(new HttpRequestMessage(HttpMethod.Get, requester.BuildString(RequestType.Transfers, parameters)));
            return JsonConvert.DeserializeObject<Transfer>(result);
        }

        public PlayerStatisticalData GetStatisticalData(Parameters parameters)
        {
            var result = requester.GetResult(new HttpRequestMessage(HttpMethod.Get, requester.BuildString(RequestType.Transfers, parameters)));
            return JsonConvert.DeserializeObject<PlayerStatisticalData>(result);
        }

        public async Task<PlayerStatisticalData> GetStatisticalDataAsync(Parameters parameters)
        {
            var result = await requester.GetResultAsync(new HttpRequestMessage(HttpMethod.Get, requester.BuildString(RequestType.Transfers, parameters)));
            return JsonConvert.DeserializeObject<PlayerStatisticalData>(result);
        }
    }
}