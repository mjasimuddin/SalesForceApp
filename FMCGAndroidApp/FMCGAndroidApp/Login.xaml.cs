using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace FMCGAndroidApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}
        private async void AddButton_OnClicked(object sender, EventArgs e)
            {

            HttpClient client = new HttpClient();

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("email", Username.Text),
                new KeyValuePair<string, string>("password", Password.Text),
            });
            var response = await client.PostAsync("http://localhost:32331/api/SellOrder/", content);

            Navigation.PushModalAsync(new SellForceOrder());


            }

        }
    }
