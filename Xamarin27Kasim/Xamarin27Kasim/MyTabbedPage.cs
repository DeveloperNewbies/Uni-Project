using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin27Kasim.TabbedSayfalar;

namespace Xamarin27Kasim
{
    public class MyTabbedPage : TabbedPage
    {
        public MyTabbedPage()
        {
            Children.Add(new Page1());
            Children.Add(new Page2());
            Children.Add(new Page3());
            Children.Add(new Page4());

        }
    }
}
