using System.Threading.Tasks;
using WOTGE_Xamarin.Services;
using Xamarin.Forms;

namespace WOTGE_Xamarin
{
    public partial class MainPage : ContentPage
    {
        private readonly IQuoteService _quoteService;

        public MainPage(IQuoteService quoteService)
        {
            InitializeComponent();
            _quoteService = quoteService;
            BindingContext = this;
        }

        private async Task SetDailyQuoteAsync(object sender, System.EventArgs e)
        {
            var label = Content.FindByName<Label>("DailyQuoteLabel");

            label.Text = await _quoteService.GetQuoteAsync();
        }
    }
}
