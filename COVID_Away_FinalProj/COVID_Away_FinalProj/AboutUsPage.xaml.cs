using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace COVID_Away_FinalProj
{
    public partial class AboutUsPage: ContentPage
    {
        public AboutUsPage()
        {
            InitializeComponent();
        }

        private void OptionPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}
