using Foundation;
using UIKit;
using LaRZ.Interfaces;
using Xamarin.Forms;
using LaRZ.iOS;

[assembly: Dependency(typeof(ShareService))]
namespace LaRZ.iOS
{
    class ShareService : ISocial
    {
        public void ShareLink(string Text)
        {
            var window = UIApplication.SharedApplication.KeyWindow;
            var rootViewController = window.RootViewController;

            var activityViewController = new UIActivityViewController(new NSString[] { new NSString(Text) }, null);

            rootViewController.PresentViewController(activityViewController, true, null);
        }
    }
}