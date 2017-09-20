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
	public partial class AddBarang : ContentPage
	{
		public AddBarang ()
		{
			InitializeComponent ();
		}
        public void OnSaveClicked(object sender, EventArgs args)
        {
            var vBarang = new Barang()
            {
                TransBar = txtTransBar.Text,
                HrgBar = txtHarga.Text,
                Tanggal = txtTanggal.Text,
                InfoBar = txtInfoBar.Text
            };
            App.DBUtils.SaveBarang(vBarang);
            Navigation.PushAsync(new ManageBarang());
        }
	}
}
