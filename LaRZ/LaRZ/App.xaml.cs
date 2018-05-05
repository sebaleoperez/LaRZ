using LaRZ.Pages;
using Xamarin.Forms;

namespace LaRZ
{
    public partial class App : Application
    {
        public static MasterDetailPage MenuItem { get; set; }
        public static bool IsPLaying { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
