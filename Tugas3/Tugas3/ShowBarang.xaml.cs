using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tugas3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShowBarang : ContentPage
	{
        Barang mSelBarang;
		public ShowBarang (Barang aSelectedBar)
		{
			InitializeComponent ();
            mSelBarang = aSelectedBar;
            BindingContext = mSelBarang;
		}
        public void OnEditClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new EditBarang(mSelBarang));
        }
        public async void OnDeleteClicked(object sender, EventArgs args)
        {
            bool accepted = await DisplayAlert("Konfirmasi", "Apakah anda yakin untuk mendelete data ?", "Yes", "No");
            if (accepted)
            {
                App.DBUtils.DeleteBarang(mSelBarang);
            }
            await Navigation.PushAsync(new ManageBarang());
        }


    }
}
