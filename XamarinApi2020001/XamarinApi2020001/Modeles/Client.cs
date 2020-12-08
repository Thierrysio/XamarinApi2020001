using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinApi2020001.Modeles
{
    class Client
    {
        #region Attributs
        public static List<Client> CollClasse = new List<Client>();

        private int _id;
        private string _nom;
        private string _prenom;

        #endregion
        #region Constructeurs
        public Client(int id, string nom, string prenom)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
            Client.CollClasse.Add(this);
        }

        #endregion
        #region Getters Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }

        #endregion
        #region Methodes
        
        #endregion
    }
}
