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
    public partial class Covid19Facts : ContentPage
    {
        public Covid19Facts()
        {
            InitializeComponent();
        }

        private void BackToMainPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CovidPage());
        }

        private void OptionPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}