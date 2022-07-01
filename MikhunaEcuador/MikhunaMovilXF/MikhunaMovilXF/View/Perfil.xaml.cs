using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MikhunaMovilXF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Perfil : ContentPage
    {
        public Perfil()
        {
            InitializeComponent();
        }

        async void GoToAddFood(Object e, EventArgs sender)
        {
            await Navigation.PushAsync(new AgregarReceta());

        }
        async void GoToProfile(Object e, EventArgs sender)
        {
            await Navigation.PushAsync(new Perfil());

        }
        async void GoToHome(Object e, EventArgs sender)
        {
            await Navigation.PushAsync(new Home());

        }

        async void GoToLogin(Object e, EventArgs sender)
        {
            await Navigation.PushAsync(new LoginPage());

        }
    }
}