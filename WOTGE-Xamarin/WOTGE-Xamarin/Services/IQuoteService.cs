using System.Threading.Tasks;

namespace WOTGE_Xamarin.Services
{
    public interface IQuoteService
    {
        Task<string> GetQuoteAsync();
    }
}
