using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision2023.Modeles
{
    internal class Voiture
    {
        #region Attributs

        public static List<Voiture> CollClasse = new List<Voiture>();
        private string _immatriculation;      
        private List<Parking> _lesParkings;

        #endregion

        #region Constructeurs

        public Voiture(string immatriculation)
        {
            Voiture.CollClasse.Add(this);
            _immatriculation = immatriculation;
            _lesParkings = new List<Parking>();
            
        }


        #endregion

        #region Getters/Setters
        public string Immatriculation { get => _immatriculation; set => _immatriculation = value; }
        public List<Parking> LesParkings { get => _lesParkings;  }


        #endregion

        #region Methodes

        #endregion
    }
}
