using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using WOTGE_Xamarin.Services;

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

        //public StartViewModel Start => ServiceLocator.Current.GetInstance<StartViewModel>();

        private void RegisterServices()
        {
            SimpleIoc.Default.Register<INavigationService, NavigationService>();
            //SimpleIoc.Default.Register<IOrderService>(() => OrderServiceMockFactory.CreateOrderServiceMock().Object);
        }

        private void RegisterViewModels()
        {
            //SimpleIoc.Default.Register<StartViewModel>();
        }

        private void SetupNavigation()
        {
            var navigationService = ServiceLocator.Current.GetInstance<INavigationService>();
            //navigationService.Register<StartViewModel, StartPage>();
        }
    }
}