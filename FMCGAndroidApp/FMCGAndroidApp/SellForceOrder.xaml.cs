using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FMCGAndroidApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SellForceOrder : ContentPage
	{
		public SellForceOrder ()
		{
			InitializeComponent ();
		}
        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            var shop = (Picker)sender;
            int selectedShop = shop.SelectedIndex;

            var category = (Picker)sender;
            int selectedCategory = shop.SelectedIndex;

            var item = (Picker)sender;
            int selectedItem = shop.SelectedIndex;

            //if (selectedIndex != -1)
            //{
            //    monkeyNameLabel.Text = picker.Items[selectedIndex];
            //}
        }
        private void AddButton_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Hey!", "Your record has been added", "OK");
        }
    }
}