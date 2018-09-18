using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using System.Net.Http;
using WOTGE_Xamarin.Services;
using WOTGE_Xamarin.ViewModels;

namespace WOTGE_Xamarin
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            RegisterServices();
            RegisterViewModels();
            SetupNavigation();
        }

        public MainPageViewModel Main => ServiceLocator.Current.GetInstance<MainPageViewModel>();

        private void RegisterServices()
        {
            SimpleIoc.Default.Register<INavigationService, NavigationService>();
            SimpleIoc.Default.Register<IQuoteService, QuoteService>();
            SimpleIoc.Default.Register(() => new HttpClient());
        }

        private void RegisterViewModels()
        {
            SimpleIoc.Default.Register<MainPageViewModel>();
        }

        private void SetupNavigation()
        {
            var navigationService = ServiceLocator.Current.GetInstance<INavigationService>();
            //navigationService.Register<StartViewModel, StartPage>();
        }
    }
}