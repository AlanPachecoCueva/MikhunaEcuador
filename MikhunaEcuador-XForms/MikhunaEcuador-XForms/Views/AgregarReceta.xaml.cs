using MikhunaEcuador_XForms.Models;
using MikhunaEcuador_XForms.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MikhunaEcuador_XForms.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new AgregarRecetaViewModel();
        }
    }
}