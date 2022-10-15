using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace ProjektKCK
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void OnLoginClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MapPage());
            Navigation.RemovePage(this);
        }
        async void OnRegisterClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new RegisterPage());
            Navigation.RemovePage(this);
        }
    }
}
