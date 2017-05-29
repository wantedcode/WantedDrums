using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WantedDrums
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

            bool a = false;
        private void Button_OnClicked(object sender, EventArgs e)
        {
            a = !a;
            cos.Text = a ? "Rumbumber" : "Meśkśkśkśkste";
            int i;
        }
    }
}
