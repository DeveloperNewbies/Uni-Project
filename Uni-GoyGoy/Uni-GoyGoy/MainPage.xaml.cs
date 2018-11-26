using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Uni_GoyGoy
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {

            InitializeComponent();
<<<<<<< HEAD
            this.BackgroundColor = Color.Red ;
=======
            this.BackgroundColor = Color.Black ;
>>>>>>> parent of b4f7a6b... Update MainPage.xaml.cs
            UI screen = new UI();

            screen.getLogin_UI();
            this.Content = screen.getScreen();
        }
    }
}
