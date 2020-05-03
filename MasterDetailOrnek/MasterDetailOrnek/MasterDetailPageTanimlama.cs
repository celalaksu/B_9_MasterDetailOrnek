using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using MasterDetailOrnek.Sayfalar;

namespace MasterDetailOrnek
{
    public class MasterDetailPageTanimlama : MasterDetailPage
    {
        public MasterDetailPageTanimlama()
        {
            var ana = new MenuSayfasi();
            this.Master = ana;
            this.Detail = new NavigationPage(new Sayfa1());
            this.MasterBehavior = MasterBehavior.Popover;

            ana.SecilenSayfa += AnaSayfaSecildi;
        }

        private void AnaSayfaSecildi(object sender, string e)
        {
            Page sayfa;
            switch (e)
            {
                case "sayfa1":
                    sayfa = new Sayfa1();
                    break;
                case "sayfa2":
                    sayfa = new Sayfa2();
                    break;
                default:
                    sayfa = new Sayfa1();
                    break;
            }

            Detail = new NavigationPage(sayfa);
            IsPresented = false;
        }

    }
}
