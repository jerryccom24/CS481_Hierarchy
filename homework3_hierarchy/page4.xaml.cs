using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace homework3_hierarchy
{
    public partial class page4 : ContentPage
    {
        public page4()
        {
            InitializeComponent();


        }



        //When user clicks button, it will pop them all the way from
        //the page4.xaml to the root page.
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Alert", "You have left the 2-PAGE-DEEP page.", "OK");
            Navigation.PopToRootAsync();
            
        }

        //Overide on appearing so that it displays the alert
        //Then, based on the users answer we output if it was a good answer or a great answer
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            bool x = await DisplayAlert("Question", "Is pineannple a good topping for pizza?", "Yes", "No");
            if (x)//They answered "No"
                this.answer.Text = "You Answered: \"Yes\" \n I urge you to reconsider!";

            else//They answered "Definitely No"
                this.answer.Text = "You Answered: \"No\" \n Great Answer!";
        }

        //On Disappear, It will display the alert that you have left the 2-PAGE-DEEP page
        async void ContentPage_Disappearing(System.Object sender, System.EventArgs e)
        {
            await DisplayAlert("Alert", "You have left the 2-PAGE-DEEP page.", "OK");
        }




    }
}
