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
	public partial class ManageBarang : ContentPage
	{
		public ManageBarang ()
		{
			InitializeComponent ();
            var vList = App.DBUtils.GetAllBarang();
            lsData.ItemsSource = vList;
		}
        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) { return; }
            var vSelUser = (Barang)e.SelectedItem;
            Navigation.PushAsync(new ShowBarang(vSelUser));
        }
        public void OnNewClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddBarang());
        }
	}
}
