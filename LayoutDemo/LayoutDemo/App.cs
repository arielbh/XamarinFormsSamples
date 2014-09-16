using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LayoutDemo.Samples;
using Xamarin.Forms;

namespace LayoutDemo
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new NavigationPage(new LoginView { BindingContext = new LoginViewModel()});
        }
    }
}
