using System;
using Xamarin.Forms;

namespace LaRZ.Pages
{
    public partial class LaRadioPage : ContentPage
    {
        public LaRadioPage()
        {
            InitializeComponent();

            lblText.Text = "LaRz nació como proyecto en Enero de 2015. La emisora vino a complementar la necesidad del GrupoZonica de brindar a los oyentes mayor diversidad y pluralidad de voces en la vida radial por Internet.\n\n" +
                "Luego del éxito y prestigio ganado a lo largo de 10 años en la Radio matriz del grupo, RadioZonica, decidimos apostar al crecimiento y expansión.  Es por ello que sumar LaRz a la oferta implica para nosotros más responsabilidad como medio  en la variedad Radial de la ciudad.\n\n" +
                "Nuestros valores como grupo siguen siendo el desarrollo como un medio independiente y con pluralidad de voces con programación dirigida a un público heterogéneo  incorporando en la grilla magazines, entrevistas, cultura, deporte, política, actualidad y ciclos educativos.\n\n" +
                "Desde LaRz seguiremos sorprendiendo y evolucionado con nuestros propios contenidos.\n\n" +
                "Nuestro principal desafío como grupo referente del medio es seguir sumando creatividad en la interacción con nuestros oyentes manteniendo el prestigio ganado a base de esfuerzo y dedicación para brindarle al oyente lo que busca al elegir Internet como medio de información.\n\n";
        }

        private void Url_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.larz.com.ar"));
        }
    }
}