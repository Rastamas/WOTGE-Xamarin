using GalaSoft.MvvmLight;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WOTGE_Xamarin.Services
{
    public interface INavigationService
    {
        Task NavigateAsync<TViewModel>() where TViewModel : ViewModelBase;
        Task NavigateBackAsync();
        void Register<TViewModel, TPage>() where TViewModel : ViewModelBase where TPage : ContentPage;
    }
}