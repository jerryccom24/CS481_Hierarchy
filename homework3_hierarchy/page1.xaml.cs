using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace homework3_hierarchy
{
    public partial class page1 : ContentPage
    {
        public page1()
        {
            InitializeComponent();
        }

        void GoToWeb(Object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.imdb.com/title/tt0381061/"));
        }
    }
}
