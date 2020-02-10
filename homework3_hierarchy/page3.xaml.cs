using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace homework3_hierarchy
{
    public partial class page3 : ContentPage
    {
        public page3()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new page4());
            DisplayAlert("Question","Is pineannple a good topping for pizza?","No","Definitely No");
        }
    }
}
