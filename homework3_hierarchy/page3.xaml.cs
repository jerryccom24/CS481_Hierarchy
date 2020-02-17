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
            //When user pressses BONUS QUESTION
            
            Navigation.PushAsync(new page4());
            

        }
    }
}
