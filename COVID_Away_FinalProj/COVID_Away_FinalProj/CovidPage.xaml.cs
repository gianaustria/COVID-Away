using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace COVID_Away_FinalProj
{
    public partial class CovidPage : ContentPage
    {
        public CovidPage()
        {
            InitializeComponent();
        }

        private void GoToPage2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Covid19Facts());
        }

    

        private void Result_Clicked(object sender, EventArgs e)
        {
            

            string result = " ";
            
            if (question1.SelectedItem.ToString() == "Yes" && question2.SelectedItem.ToString() == "Yes" && question3.SelectedItem.ToString() == "Yes")
            {
                result = "You have COVID-19 you need to be tested!";
            }
            else if (question1.SelectedItem.ToString() == "Yes" && question2.SelectedItem.ToString() == "No" && question3.SelectedItem.ToString() == "Yes")
            {
                result = "High chances that you have COVID-19 you need to be tested!";
            }
            else if (question1.SelectedItem.ToString() == "Yes" && question2.SelectedItem.ToString() == "No" && question3.SelectedItem.ToString() == "No")
            {
                result = "Low chances that you have COVID-19 but it is still better to be tested!";
            }
            else if (question1.SelectedItem.ToString() == "Yes" && question2.SelectedItem.ToString() == "Yes" && question3.SelectedItem.ToString() == "No")
            {
                result = "High chances that you have COVID-19 you need to be tested!";
            }
            else if (question1.SelectedItem.ToString() == "No" && question2.SelectedItem.ToString() == "Yes" && question3.SelectedItem.ToString() == "Yes")
            {
                result = "High chances that you have COVID-19 you need to be tested!";
            }
            else if (question1.SelectedItem.ToString() == "No" && question2.SelectedItem.ToString() == "Yes" && question3.SelectedItem.ToString() == "No")
            {
                result = "You don't have COVID-19 but it is still better to be tested!";
            }
            else if (question1.SelectedItem.ToString() == "No" && question2.SelectedItem.ToString() == "No" && question3.SelectedItem.ToString() == "No")
            {
                result = "You don't have COVID-19 but it is still better to be tested!";
            }

            Navigation.PushAsync(new Result(result));
        }

        private void OptionPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}
