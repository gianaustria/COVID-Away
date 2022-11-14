using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace COVID_Away_FinalProj
{
    public partial class DonationPage : ContentPage
    {
        public DonationPage()
        {
            InitializeComponent();
        }

        private void Donate_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Donate", "You have successfully donated! Thank you and God bless", "Close");
        }

        private void OptionPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}
