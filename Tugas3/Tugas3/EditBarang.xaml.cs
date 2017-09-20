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
	public partial class EditBarang : ContentPage
	{
        Barang mSelBarang;
        public EditBarang(Barang mSelectedBar)
        {
            InitializeComponent();
            Barang aSelectedBar = null;
            mSelBarang = aSelectedBar;
            BindingContext = mSelBarang;
        }
        public void OnSaveClicked(object sender, EventArgs args)
        {
            mSelBarang.TransBar = txtTransBar.Text;
            mSelBarang.HrgBar = txtHrgBar.Text;
            mSelBarang.Tanggal = txtTanggal.Text;
            mSelBarang.InfoBar = txtInfoBar.Text;
            App.DBUtils.EditBarang(mSelBarang);
            Navigation.PushAsync(new ManageBarang());
        }
    }
}
