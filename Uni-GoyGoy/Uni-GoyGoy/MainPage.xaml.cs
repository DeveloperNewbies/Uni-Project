﻿using System;
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

            this.BackgroundColor = Color.Magenta ;

            UI screen = new UI();

            screen.getLogin_UI();
            this.Content = screen.getScreen();
        }
    }
}
