﻿using ClassLibrary1.Infra;
using ClassLibrary1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassLibrary1.Models
{
    //I had to mark a using for IEntity and for Infra
    public partial class Lettre : IEntity<CompositeKey<int, int>>
    {
        private int _idMembre;
        private int _idEvenement;
        private string _contenu;



        public int IdMembre
        {
            get
            {
                return _idMembre;
            }

            set
            {
                _idMembre = value;
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

        public string Contenu
        {
            get
            {
                return _contenu;
            }

            set
            {
                _contenu = value;
            }
        }

        public Evenement Evenement { get; set; }
        public Membre Membre { get; set; }

        public CompositeKey<int, int> Id
        {
            get
            {
                return new CompositeKey<int, int>() { PK1 = IdMembre, PK2 = IdEvenement };
            }
        }
    }
}
