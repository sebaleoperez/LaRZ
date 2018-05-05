using Android.App;
using Android.Content;
using Xamarin.Forms;
using LaRZ.Interfaces;
using LaRZ.Droid;

[assembly: Dependency(typeof(ShareService))]
namespace LaRZ.Droid
{
    class ShareService : ISocial
    {
        public void ShareLink(string Title)
        {
            var context = Forms.Context;
            Activity activity = context as Activity;

            Intent share = new Intent(Intent.ActionSend);
            share.SetType("text/plain");
            share.AddFlags(ActivityFlags.ClearWhenTaskReset);
            share.PutExtra(Intent.ExtraText, Title);

            activity.StartActivity(Intent.CreateChooser(share, "Compartir!"));
        }
    }
}