using ClassLibrary1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassLibrary1.Models
{
    //I had to mark a using for IEntity
    public partial class Groupe : IEntity<int>
    {



        private int _idGroupe;
        private string _nom;
        private string _description;
        private int _idEvenement;



        public int IdGroupe
        {
            get
            {
                return _idGroupe;
            }

            set
            {
                _idGroupe = value;
            }
        }

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

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
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
        public Evenement Evenement { get; set; }
        public Membre Admin { get; set; }
        public IEnumerable<Membre> MembreGroupe { get; set; }

        public int Id
        {
            get
            {
                return IdGroupe;
            }
        }

        public Groupe()
        {
            this.MembreGroupe = new List<Membre>();
        }
    }
}