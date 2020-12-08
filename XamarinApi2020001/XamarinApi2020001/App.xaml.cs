using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApi2020001.Vues;

namespace XamarinApi2020001
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ClientVue();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
