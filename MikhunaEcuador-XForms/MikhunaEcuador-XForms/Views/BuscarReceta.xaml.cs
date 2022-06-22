using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MikhunaEcuadorXForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuscarReceta : ContentPage
    {
        public BuscarReceta()
        {
            InitializeComponent();

            Reset();
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


        /*Para calificar Receta*/
        void Reset()
        {
            ChangeTextColor(5, Color.Gray);
        }

        void ChangeTextColor(int starcount, Color color)
        {
            for (int i = 1; i <= starcount; i++)
            {
                (FindByName($"star{i}") as Label).TextColor = color;
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Reset();
            Label clicked = sender as Label;
            ChangeTextColor(Convert.ToInt32(clicked.StyleId.Substring(4, 1)), Color.Yellow);
        }

        async void GoToLogin(Object e, EventArgs sender)
        {
            await Navigation.PushAsync(new LoginPage());

        }



        /*-------------------------------------*/
    }
}