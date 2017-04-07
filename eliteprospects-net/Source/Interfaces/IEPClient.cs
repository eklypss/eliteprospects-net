using eliteprospects_net.Source.Model;
using eliteprospects_net.Source.Model.Parameters;
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
    }
}