
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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void GoToRegister(Object e, EventArgs sender)
        {
            await Navigation.PushAsync(new RegisterPage());

        }

        async void GoToHome(Object e, EventArgs sender)
        {
            await Navigation.PushAsync(new Home());

        }

    }
}