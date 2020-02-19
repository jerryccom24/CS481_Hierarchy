using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace homework3_hierarchy
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //These booleans below will become true if a navipage button has been pressed
        //Then, each button wil turn to a darker shade of the button color to
        //signify that it has been pressed...
        bool button1Clicked = false;
        bool button2Clicked = false;
        bool button3Clicked = false;


        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new page1());//push our page1
            button1Clicked = true;//button has been pressed
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new page2());//push our page2
            button2Clicked = true;//button has been pressed
            
        }

        void Button_Clicked_2(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new page3());//push our page3
            button3Clicked = true;//button has been pressed

        }

        //DISAPPEARING EVENTS

        //NOTE: When Running this on Android, I noticed a weird bug that
        // the color of the button would not change unless I clicked the button
        // and entered the page TWICE... This was not occurring at ALL when testing
        // on iPhone (Which I primarily use).
        void ContentPage_Disappearing(System.Object sender, System.EventArgs e)
        {
            if (button1Clicked)
            {
                this.button1.BackgroundColor = Color.Red;//change to darker shade
            }

            if (button2Clicked)
            {
                this.button2.BackgroundColor = Color.Blue;//change to darker shade
            }

            if (button3Clicked)
            {
                this.button3.BackgroundColor = Color.Yellow;//change to darker shade
            }
        }
    }
}
