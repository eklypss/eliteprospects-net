using System.Threading.Tasks;

namespace eliteprospects_net.Source.Interfaces
{
    public interface IEPClient
    {
        /// <summary>
        /// Functions for retrieving data about retired numbers.
        /// </summary>
        RetiredNumber GetRetiredNumber(Parameters parameters);

        Task<RetiredNumber> GetRetiredNumberAsync(Parameters parameters);

        /// <summary>
        /// Functions for retrieving data about transfers.
        /// </summary>
        Transfer GetTransfer(Parameters parameters);

        Task<Transfer> GetTransferAsync(Parameters parameters);

        /// <summary>
        /// Functions for retrieving data about player statistical data.
        /// </summary>
        PlayerStatisticalData GetStatisticalData(Parameters parameters);

        Task<PlayerStatisticalData> GetStatisticalDataAsync(Parameters parameters);
    }
}