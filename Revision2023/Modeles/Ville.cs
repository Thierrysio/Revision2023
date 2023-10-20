using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision2023.Modeles
{
    internal class Ville
    {
        #region Attributs

        public static List<Ville> CollClasse = new List<Ville>();
        private string _nom;

        #endregion

        #region Constructeurs

        public Ville(string nom)
        {
            Ville.CollClasse.Add(this);
            _nom = nom;
        }


        #endregion

        #region Getters/Setters
        public string Nom { get => _nom; set => _nom = value; }

        #endregion

        #region Methodes

        #endregion
    }
}

