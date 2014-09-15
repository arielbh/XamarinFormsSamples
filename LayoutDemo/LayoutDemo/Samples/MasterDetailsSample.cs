using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutDemo.Samples
{
    class MasterDetailsSample : MasterDetailPage
    {
        private ListView _listView;

        public MasterDetailsSample()
        {
            Master = new ContentPage
            {
                Title = "Crazy People",
                Content = _listView = new ListView
                {
                    ItemsSource = new[]
                    {
                        "Pavel",
                        "Ariel",
                        "Margol"
                    }
                }
            };
            Detail = new Page2();
            IsPresented = true;
            // Define a selected handler for the ListView.
            _listView.ItemSelected += (sender, args) =>
            {
                // Set the BindingContext of the detail page.
                this.Detail.BindingContext = args.SelectedItem;

                // Show the detail page.
                this.IsPresented = false;
            };
        }
    }
}
