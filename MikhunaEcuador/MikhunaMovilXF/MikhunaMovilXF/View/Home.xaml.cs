using MikhunaMovilXF.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MikhunaMovilXF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();


        }

        //Recetas de API
        private async void cargarRecetas(Object e, EventArgs sender) {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                var request = new HttpRequestMessage();
                request.RequestUri = new Uri("10.0.2.2:44308/api/Recetas");
                //request.RequestUri = new Uri("http://192.168.100.33:44308/api/Recetas");
                request.Method = HttpMethod.Get;
                request.Headers.Add("Accept", "application/json");
                var receta = new HttpClient();

                HttpResponseMessage response = await receta.SendAsync(request);

                if (response.StatusCode == HttpStatusCode.OK) {
                    string content = await response.Content.ReadAsStringAsync();
                    var res = JsonConvert.DeserializeObject<List<Recetas>>(content);

                    ListaRecetas.ItemsSource = res;
                }

            }
        }

        //Navegación entre pestañas (footer)
        async void GoToAddFood(Object e, EventArgs sender) {
            await Navigation.PushAsync(new AgregarReceta());

        } 
        async void GoToProfile(Object e, EventArgs sender) {
            await Navigation.PushAsync(new Perfil());

        } 
        async void GoToHome(Object e, EventArgs sender) {
            await Navigation.PushAsync(new Home());

        } 
        
        async void GoToBuscarReceta(Object e, EventArgs sender) {
            await Navigation.PushAsync(new BuscarReceta());

        } 
        async void GoToLogin(Object e, EventArgs sender) {
            await Navigation.PushAsync(new LoginPage());

        } 
    }
}