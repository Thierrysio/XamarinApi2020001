using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using XamarinApi2020001.Modeles;
using XamarinApi2020001.Services;

namespace XamarinApi2020001.VuesModeles
{
    class ClientVueModele : BaseVueModele
    {
        #region Attributs
        private ObservableCollection<Client> maListeClients;
        private readonly Api _apiServices = new Api();
        public ClientVueModele()
        {
             this.GetListe();
        }
    #endregion
    #region Constructeurs

    #endregion
    #region Getters Setters
    public ObservableCollection<Client> MaListeClients
        {
            get { return maListeClients; }
            set { SetProperty(ref maListeClients, value); }
        }
        #endregion 
        #region Methodes
       public async void GetListe()
        {
          MaListeClients = await _apiServices.GetAllAsync<Client>("api/clients",Client.CollClasse);
        }
    }
        #endregion
    }

