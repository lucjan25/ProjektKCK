using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjektKCK
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
        }
        async void OnZamowClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ZamowPage());
            Navigation.RemovePage(this);
        }
    }
}