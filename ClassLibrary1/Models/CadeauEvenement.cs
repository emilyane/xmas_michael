using ClassLibrary1.Infra;
using ClassLibrary1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassLibrary1.Models
{
    //I had to mark a using for IEntity and for the Infra
    public partial class CadeauEvenement : IEntity<CompositeKey<int, int>>
    {
        private int _idCadeau;
        private int _idEvenement;
        private bool _preference;



        public int IdCadeau
        {
            get
            {
                return _idCadeau;
            }

            set
            {
                _idCadeau = value;
            }
        }

        public int IdEvenement
        {
            get
            {
                return _idEvenement;
            }

            set
            {
                _idEvenement = value;
            }
        }

        public bool Preference
        {
            get
            {
                return _preference;
            }

            set
            {
                _preference = value;
            }
        }

        public Cadeau Cadeau { get; set; }
        public Evenement Evenement { get; set; }

        public CompositeKey<int, int> Id
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
