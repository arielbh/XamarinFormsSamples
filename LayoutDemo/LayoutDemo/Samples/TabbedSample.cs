using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutDemo.Samples
{
    class TabbedSample : TabbedPage
    {
        public TabbedSample()
        {
            Title = "Tabs Sample";
            Children.Add(new Page1());
            Children.Add(new Page2());
        }
    }
}
