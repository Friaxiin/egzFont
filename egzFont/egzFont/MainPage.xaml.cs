using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace egzFont
{
    public partial class MainPage : ContentPage
    {
        public static string[] quotes = { "Dzień dobry", "Good morning", "Buenos dias" };
        public static int counter = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void QuoteChangeButtonClicked(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                counter++;
                
            }
            else
            {
                counter = 0;
                
            }
            quouteLbl.Text = quotes[counter];
        }

        private void QuoteChangeSize(object sender, ValueChangedEventArgs e)
        {
            int value = (int)slider.Value;
            sizeLbl.Text = value.ToString();

            quouteLbl.FontSize = value;
        }
    }
}
