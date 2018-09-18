using Android.App;
using Android.Content.PM;
using Android.OS;
using GalaSoft.MvvmLight.Ioc;
using WOTGE_Xamarin.Droid.Services;
using WOTGE_Xamarin.Interfaces;

namespace WOTGE_Xamarin.Droid
{
    [Activity(Label = "WOTGE_Xamarin", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            RegisterDroidServices();

            LoadApplication(new App());
        }

        private void RegisterDroidServices()
        {
            SimpleIoc.Default.Register<INotifierService>(() => new ToastNotiferService(this));
        }
    }
}