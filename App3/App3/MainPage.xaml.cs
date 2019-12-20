using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, ElementEventArgs e)
        {
            LoginInformation logininformation = new LoginInformation()
            {

                Username = userEntry.Text,
                Password = passwordEntry.Text


            };

           
        }

        private new void DisplayAlert(string v, string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}
