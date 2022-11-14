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
    public partial class Result : ContentPage
    {
        public Result(string result)
        {
            InitializeComponent();

            this.result.Text = result;
        }

        private void OptionPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void GoToPage2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Covid19Facts());
        }
    }
}