using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace LayoutDemo.Samples
{
    public partial class LayoutView
    {
        public LayoutView()
        {
            InitializeComponent();
            BindingContext = new {MainText = "Ariel"};
        }
    }
}
