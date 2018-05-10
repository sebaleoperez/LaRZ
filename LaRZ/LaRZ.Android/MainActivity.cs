using Android.App;
using Android.Content.PM;
using Android.OS;
using Firebase.Analytics;

namespace LaRZ.Droid
{
    [Activity(Label = "LaRZ", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            RequestedOrientation = ScreenOrientation.Portrait;

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

			var firebase = FirebaseAnalytics.GetInstance(this);
			firebase.LogEvent(FirebaseAnalytics.Event.AppOpen, null);

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

