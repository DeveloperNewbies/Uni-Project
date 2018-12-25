using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin27Kasim.TabbedSayfalar;

namespace Xamarin27Kasim.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SpecialPage : ContentPage
	{
		public SpecialPage ()
		{
			InitializeComponent ();
		}
        private  void Button_Clicked(object sender,EventArgs e)
        {

           Navigation.PushAsync(new MyTabbedPage());

        }

	}
}