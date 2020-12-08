using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApi2020001.VuesModeles;

namespace XamarinApi2020001.Vues
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientVue : ContentPage
    {
        ClientVueModele viewModel;
        public ClientVue()
        {
            InitializeComponent();
            BindingContext = viewModel = new ClientVueModele();

        }
    }
}