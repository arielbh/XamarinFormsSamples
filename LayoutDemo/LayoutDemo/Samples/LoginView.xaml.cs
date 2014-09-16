using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutDemo.Samples
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
            this.BindingContextChanged += LoginViewBindingContextChanged;
        }

        void LoginViewBindingContextChanged(object sender, EventArgs e)
        {
            (BindingContext as LoginViewModel).Navigation = Navigation;
        }
    }
}
