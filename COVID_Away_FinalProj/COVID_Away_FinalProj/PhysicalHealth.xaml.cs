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
    public partial class PhysicalHealth : ContentPage
    {
        public PhysicalHealth()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private void OptionMenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

       
    }
}