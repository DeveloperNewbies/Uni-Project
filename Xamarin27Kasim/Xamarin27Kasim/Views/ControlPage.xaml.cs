using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin27Kasim.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ControlPage : ContentPage
	{
		public ControlPage ()
		{
			InitializeComponent ();
            myDatePicker.MinimumDate = DateTime.Now.AddYears(-1);
            myDatePicker.MaximumDate = DateTime.Now.AddYears(0);
            myDatePicker.Date = DateTime.Now;
            myDatePicker.Format = "yyyy-MM-dd";

            Label header = new Label
            {
                Text = "WebView",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center



            };
            WebView wView = new WebView
            {

                Source = new UrlWebViewSource
                {
                    Url = "http://www.ay-soft.com",
                },
                VerticalOptions = LayoutOptions.FillAndExpand

            };
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    wView

                }
            };
		}
        int i = 0;
        private void onClicked(object sender, EventArgs e)
        {
            progressBar.ProgressTo(.8, 1250, Easing.SpringIn);
            if (i % 2 == 0)

                activity.IsRunning = true;
            else
                activity.IsRunning = false;
            i++;
          

        }
        private void pickerOnChanged(object sender,EventArgs e)
        {
            Picker pckr = (Picker)sender;
            string selected = pckr.Items[pckr.SelectedIndex];
            DisplayAlert("Picker", selected, "OK", "CANCEL");

        }
        private void onStepperValueChanged(object sender,ValueChangedEventArgs e)
        {
            lblStepper.Text = e.NewValue.ToString();
        }
        private async void onToggled(object sender, ToggledEventArgs e)
        {
           bool isOK = await DisplayAlert("Switch", e.Value.ToString(),"OK","CANCEL");
           if (isOK == true)
            {
              
                //OKKi
            }
            else
            {
              
                //Nope
            }
        }

    }
}