using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision2023.Modeles
{
    internal class Parking
    {
        #region Attributs

        public static List<Parking> CollClasse = new List<Parking>();
        private float _latitude;
        private float _longitude;
        private int _nb;
        private Ville _laVille;

        #endregion

        #region Constructeurs

        public Parking(float latitude, float longitude, Ville laVille)
        {
            Parking.CollClasse.Add(this);
            _latitude = latitude;
            _nb = 0;
            _laVille = laVille;
        }

        #endregion

        #region Getters/Setters
        public float Latitude { get => _latitude; set => _latitude = value; }
        public float Longitude { get => _longitude; set => _longitude = value; }
        public Ville LaVille { get => _laVille; set => _laVille = value; }
        #endregion

        #region Methodes

        #endregion
    }
  
}
