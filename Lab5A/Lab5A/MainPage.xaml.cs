using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab5A
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void NavigateButton_OnClicked_Grid(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Grid());
        }

        private async void NavigateButton_OnClicked_Absolute(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Absolute());
        }

        private async void NavigateButton_OnClicked_Clock(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Clock());
        }
    }
}