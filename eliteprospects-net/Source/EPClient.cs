using eliteprospects_net.Source.Enum;
using eliteprospects_net.Source.Interfaces;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace eliteprospects_net.Source
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

        public Task<RetiredNumber> GetRetiredNumberAsync(Parameters parameters)
        {
            var result = requester.GetResultAsync(new HttpRequestMessage(HttpMethod.Get, requester.BuildString(RequestType.RetiredNumbers, parameters)));
            var task = Task.Factory.StartNew(() => JsonConvert.DeserializeObject<RetiredNumber>(result.Result));
            return task;
        }

        public Transfer GetTransfer(Parameters parameters)
        {
            var result = requester.GetResult(new HttpRequestMessage(HttpMethod.Get, requester.BuildString(RequestType.Transfers, parameters)));
            return JsonConvert.DeserializeObject<Transfer>(result);
        }

        public Task<Transfer> GetTransferAsync(Parameters parameters)
        {
            var result = requester.GetResultAsync(new HttpRequestMessage(HttpMethod.Get, requester.BuildString(RequestType.Transfers, parameters)));
            var task = Task.Factory.StartNew(() => JsonConvert.DeserializeObject<Transfer>(result.Result));
            return task;
        }

        public PlayerStatisticalData GetStatisticalData(Parameters parameters)
        {
            var result = requester.GetResult(new HttpRequestMessage(HttpMethod.Get, requester.BuildString(RequestType.Transfers, parameters)));
            return JsonConvert.DeserializeObject<PlayerStatisticalData>(result);
        }

        public Task<PlayerStatisticalData> GetStatisticalDataAsync(Parameters parameters)
        {
            var result = requester.GetResultAsync(new HttpRequestMessage(HttpMethod.Get, requester.BuildString(RequestType.Transfers, parameters)));
            var task = Task.Factory.StartNew(() => JsonConvert.DeserializeObject<PlayerStatisticalData>(result.Result));
            return task;
        }
    }
}