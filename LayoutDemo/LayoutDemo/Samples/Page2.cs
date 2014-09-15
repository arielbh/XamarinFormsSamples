using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutDemo.Samples
{
    class Page2  : ContentPage
    {
        public Page2()
        {
            Title = "Page 2";
            BindingContext = "Select your favorite crazy person";
            var label = new Label() {VerticalOptions = LayoutOptions.Center};
            label.SetBinding(Label.TextProperty, new Binding());
            Content = label;
        }
    }
}
