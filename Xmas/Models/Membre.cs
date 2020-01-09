using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xmas.Models
{
    public class MembreModel
    {
        private string _nom;

        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }
    }
}