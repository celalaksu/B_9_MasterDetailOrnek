using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailOrnek
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedSayfa : TabbedPage
    {
        public TabbedSayfa()
        {
            InitializeComponent();
        }
    }
}