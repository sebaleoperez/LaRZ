using System;
using LaRZ.Interfaces;
using Xamarin.Forms;

namespace LaRZ.Pages
{
    public partial class SharePage : ContentPage
    {
        public SharePage()
        {
            InitializeComponent();

            lblWP.Text = "Agendá nuestro número y escribinos: \n11-6105-4846";
        }

        private void Whatsapp_Tapped(object sender, EventArgs e)
        {
            var uri = new Uri("tel:+5491161054846");
            Device.OpenUri(uri);
        }

        private void Share_Tapped(object sender, EventArgs e)
        {
            DependencyService.Get<ISocial>().ShareLink("Estoy escuchando La RZ!! www.larz.com.ar");
        }
    }
}