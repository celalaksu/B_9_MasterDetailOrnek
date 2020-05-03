using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MasterDetailOrnek.Sayfalar;

namespace MasterDetailOrnek
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailOrnek2 : MasterDetailPage
    {
        public MasterDetailOrnek2()
        {
            InitializeComponent();
            
            this.Detail = new NavigationPage(new Sayfa1());
           
            this.MasterBehavior = MasterBehavior.Popover;
            IsPresented = false;
        }

        private void sayfaBir_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Sayfa1());
            IsPresented = false;
        }

        private void sayfaIki_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Sayfa2());
            IsPresented = false;
        }
    }
}