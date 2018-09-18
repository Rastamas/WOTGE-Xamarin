using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Threading.Tasks;
using System.Windows.Input;
using WOTGE_Xamarin.Services;

namespace WOTGE_Xamarin.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IQuoteService _quoteService;
        private ICommand _setDailyQuote;

        public ICommand SetDailyQuote => _setDailyQuote ?? (_setDailyQuote = new RelayCommand(async () => await SetDailyQuoteAsync()));

        private string _quote = "";
        public string Quote {
            get {
                return _quote;
            }
            set {
                Set(ref _quote, value);
            }
        }

        public MainPageViewModel(IQuoteService quoteService)
        {
            _quoteService = quoteService;
        }

        public async Task SetDailyQuoteAsync()
        {
            Quote = await _quoteService.GetQuoteAsync();
        }
    }
}
