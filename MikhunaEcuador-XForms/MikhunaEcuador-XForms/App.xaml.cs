
//Para usar las views creadas
using MikhunaEcuadorXForms.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MikhunaEcuadorXForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Es la primera página que se renderiza

            //La navigation Page me permite guardar en una pila
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
