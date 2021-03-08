using System;
using System.Collections.Generic;
using System.Text;
using XamarinApi2020001.Services;

namespace XamarinApi2020001.Modeles
{
    class Client
    {
        #region Attributs
        public static List<Client> CollClasse = new List<Client>();

        private int _id;
        private string _nom;
        private string _prenom;

        private List<Boutique> _boutiques;

        #endregion
        #region Constructeurs
        public Client(int id, string nom, string prenom, List<Boutique> boutiques)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
            Boutiques = boutiques;
            this.SetObjet(boutiques, this);
            Client.CollClasse.Add(this);
        }

        #endregion
        #region Getters Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public List<Boutique> Boutiques { get => _boutiques; set => _boutiques = value; }

        #endregion
        #region Methodes
        public void SetObjet(List<Boutique> listeParam, Client param)
        {
            foreach(Boutique unParam in listeParam)
            {
                unParam.LeClient = param;
            }
        }
        #endregion
    }
}
