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
    public partial class ZamowPage : ContentPage
    {
        public ZamowPage()
        {
            InitializeComponent();
        }

        async void OnCancelClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MapPage());
            Navigation.RemovePage(this);
        }
    }
}