using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace COVID_Away_FinalProj
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void BackToMainPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void PhysicalHealth_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PhysicalHealth());
        }

        private void AboutUsPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutUsPage());
        }

        private void DonationDrive_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DonationPage());
        }

        private void COVIDPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CovidPage());
        }
    }
}