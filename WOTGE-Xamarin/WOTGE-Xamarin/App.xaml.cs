using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace WOTGE_Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //TODO: Just don't
            MainPage = new MainPage(new Services.QuoteService(new System.Net.Http.HttpClient()));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("android=1d39ab1a-201a-41a1-a9dc-bc35b7d31886;",
                  // +"uwp={Your UWP App secret here};" +
                  //"ios={Your iOS App secret here}",
                  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
