using MikhunaEcuador_XForms.Services;
using MikhunaEcuador_XForms.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MikhunaEcuador_XForms
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
