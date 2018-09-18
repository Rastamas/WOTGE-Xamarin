using Android.Content;
using Android.Widget;
using WOTGE_Xamarin.Interfaces;

namespace WOTGE_Xamarin.Droid.Services
{
    class ToastNotiferService : INotifierService
    {
        private readonly Context _context;

        public ToastNotiferService(Context context)
        {
            _context = context;
        }

        public void Notify(string text)
        {
            var toast = Toast.MakeText(_context, text, ToastLength.Long);

            toast.Show();
        }
    }
}