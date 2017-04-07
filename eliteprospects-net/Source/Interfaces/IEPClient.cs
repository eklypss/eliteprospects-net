using eliteprospects_net.Source.Model;
using eliteprospects_net.Source.Model.Parameters;
using System.Threading.Tasks;

namespace eliteprospects_net.Source.Interfaces
{
    public interface IEPClient
    {
        RetiredNumber GetRetiredNumber(Parameters parameters);

        Task<RetiredNumber> GetRetiredNumberAsync(Parameters parameters);
    }
}