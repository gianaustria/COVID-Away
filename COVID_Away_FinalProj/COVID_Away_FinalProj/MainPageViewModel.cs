using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace COVID_Away_FinalProj
{
    internal class MainPageViewModel : INotifyPropertyChanged
    {
        private double height = 180;
        private double weight = 70;
        private const double STEP = 1.0;

        public double Height
        {
            get => height;
            set
            {
                height = NextStep(value);
                RaisePropertyChanged(nameof(Bmi));
                RaisePropertyChanged(nameof(Classification));
            }
        }

        public double Weight
        {
            get => weight;
            set
            {
                weight = NextStep(value);
                RaisePropertyChanged(nameof(Bmi));
                RaisePropertyChanged(nameof(Classification));
            }
        }

        public double Bmi
            => Math.Round(Weight / Math.Pow(Height/100, 2),2);

       public string Classification
        {
            get
            {
                if (Bmi < 18.5)
                    return "Your BMI is UNDERWEIGHT" + " \nTips for you: \nEat more Frequently, " +
                        "Choose nutrient-rich foods, Make every bit count, Exercise and Exercise!!";
                else if (Bmi < 25)
                    return "Your BMI is NORMAL" + " \nTips for you: \nDrink more water, " +
                        "Track what you eat, Get more sleep, Exercise and Exercise!!";
                else if (Bmi < 30)
                    return "Your BMI is OVERWEIGHT" + " \nTips for you: \nReduce your daily intake by 500 calories, " +
                        "Limit the time you spend being physically inactive, Exercise and Exercise!!";
                else
                    return "Your BMI is OBESE" + " \nTips for you: \nFollow a healthy eating plan, " +
                        "Monitor your weight regularly, Be Consisten, Exercise and Exercise!!";

            }
        }
        
        private double NextStep(double value) => Math.Round(value / STEP) * STEP;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}