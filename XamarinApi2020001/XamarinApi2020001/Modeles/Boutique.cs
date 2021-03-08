using System;
using System.Collections.Generic;
using System.Text;
using XamarinApi2020001.Services;

namespace XamarinApi2020001.Modeles
{
    class Boutique
    {
        #region Attributs
        public static List<Boutique> CollClasse = new List<Boutique>();
        private int _id;
        private string _nomBoutique;
        private int _idClient;
        private Client _leClient;

        #endregion
        #region Constructeurs
        public Boutique(int id, string nomBoutique, int idClient)
        {
            _id = id;
            _nomBoutique = nomBoutique;
            _idClient = idClient;
            Boutique.CollClasse.Add(this);
        }

        #endregion
        #region Getters Setters
        public int id { get => _id; set => _id = value; }
        public string NomBoutique { get => _nomBoutique; set => _nomBoutique = value; }
        public int idClient { get => _idClient; set => _idClient = value; }
        public Client LeClient { get => _leClient; set => _leClient = value; }

        #endregion
        #region Methodes
        #endregion
    }
}
