using System;
using Xamarin.Forms;

namespace portfolioApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void About(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
        private async void Education(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EducationPage());
        }
        private async void Experience(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExperiencePage());
        }
        private async void Contact(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactPage());
        }
    }
}
