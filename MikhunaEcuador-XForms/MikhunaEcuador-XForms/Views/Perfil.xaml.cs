using MikhunaEcuador_XForms.Models;
using MikhunaEcuador_XForms.ViewModels;
using MikhunaEcuador_XForms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MikhunaEcuador_XForms.Views
{
    public partial class ItemsPage : ContentPage
    {
        PerfilViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new PerfilViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}