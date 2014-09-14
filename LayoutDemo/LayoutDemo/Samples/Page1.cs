using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutDemo.Samples
{
    class Page1 : ContentPage
    {
        public Page1()
        {
            Title = "Page 1";
            var button = new Button
            {
                WidthRequest = 300,
                HeightRequest = 150,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Text = "Navigate",
            };
            button.Clicked += button_Clicked;
            Content = button;
        }

        void button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }

}
