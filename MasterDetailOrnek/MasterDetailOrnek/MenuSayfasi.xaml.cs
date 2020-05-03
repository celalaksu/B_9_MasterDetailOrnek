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
    public partial class MenuSayfasi : ContentPage
    {
        public event EventHandler<String> SecilenSayfa;

        public MenuSayfasi()
        {
            InitializeComponent();
            sayfaBir.Clicked += (s, e) => SecilenSayfa?.Invoke(this, "sayfa1");
            sayfaIki.Clicked += (s, e) => SecilenSayfa?.Invoke(this, "sayfa2");            
        }        
    }
}