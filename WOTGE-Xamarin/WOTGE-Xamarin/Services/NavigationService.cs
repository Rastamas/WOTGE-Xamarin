using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WOTGE_Xamarin.Services
{
    class NavigationService : INavigationService
    {
        private readonly Dictionary<Type, Type> _vmPagePairs = new Dictionary<Type, Type>();

        public async Task NavigateAsync<TViewModel>() where TViewModel : ViewModelBase
        {
            var vmType = typeof(TViewModel);

            if (_vmPagePairs.ContainsKey(vmType))
            {
                await Application.Current.MainPage.Navigation.PushAsync(
                    (Page) Activator.CreateInstance(_vmPagePairs[vmType]));
            }
            else
            {
                throw new InvalidOperationException($"Register {vmType.Name} before trying to navigate to it!");
            }
        }

        public void Register<TViewModel, TPage>() where TViewModel : ViewModelBase where TPage : ContentPage
        {
            _vmPagePairs[typeof(TViewModel)] = typeof(TPage);
        }

        public async Task NavigateBackAsync()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}