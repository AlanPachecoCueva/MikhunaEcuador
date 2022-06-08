using MikhunaEcuador_XForms.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MikhunaEcuador_XForms.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new BuscarRecetaViewModel();
        }
    }
}