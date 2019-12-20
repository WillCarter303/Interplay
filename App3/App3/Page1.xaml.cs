using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
        private object LoginInformation;

        public Page1 ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using(SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {

                conn.CreateTable<LoginInformation>();

                var LoginInformationListView = conn.Table<LoginInformation>().ToList();
                //LoginInformationListView.ItemSource = LoginInformation;

            }
                    
                    
        }

        private void ToolbarItems_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
    }
}