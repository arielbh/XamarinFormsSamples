using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutDemo.Samples
{
    class AnimationsSample  : ContentPage
    {
        public AnimationsSample()
        {
            var button = new Button
            {
                Text = "Animate",
            };

            var box = new BoxView
            {
                WidthRequest = 100,
                HeightRequest = 100,
                Color = Color.Red,
                HorizontalOptions = LayoutOptions.Center,
            };


            var stack = new StackLayout
            {
                Padding = 10,
                Spacing = 10,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    button,
                    box
                }
            };
            this.Content = stack;

            button.Clicked += async (s, e) =>
            {
                button.IsEnabled = false;
                box.Color = Color.Green;

                var original = box.Bounds;
                var newPosition = box.Bounds;
                newPosition.Y = this.Height - box.Height;
                await box.LayoutTo(newPosition, 2000, Easing.BounceOut);

                await box.FadeTo(0, 2000);
                box.Color = Color.Yellow;
                box.ScaleTo(2, 2000);
                await box.FadeTo(1, 2000);
                box.ScaleTo(1, 2000);
                box.Color = Color.Green;
                await box.LayoutTo(original, 2000, Easing.Linear);
                box.Color = Color.Red;
                button.IsEnabled = true;
            };
        }
    }
}
