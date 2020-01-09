using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xmas.Areas.Membre.Models;
using ClassLibrary1.Models;
using Xmas.Models;


namespace Xmas.Tools.Mappers
{
    public static class MapToDBModel
    {
        public static Membre LoginToMembre(LoginModel lm)
        {
            return new Membre()
            {
                Courriel = lm.Email,
                MotDePasse = lm.Password
            };
        }

        public static MembreModel MembreToMembreModel(Membre membre)
        {
            if (membre == null) return null;
            return new MembreModel()
            {
                Nom = membre.Nom
            };
        }

        public static GroupModel GroupToGroupModel(Groupe g)
        {
            return new GroupModel()
            {
                IdGroupe = g.IdGroupe,
                Description = g.Description,
                Nom = g.Nom
            };
        }

        public static Membre RegisterToMembre(RegisterModel rm)
        {
            return new Membre()
            {
                Nom = rm.Nom,
                Prenom = rm.Prenom,
                Surnom = rm.Surnom,
                Courriel = rm.Email,
                MotDePasse = rm.MotDePasse
            };
        }

        internal static ProfileModel MemberToProfile(Membre mmodel)
        {
            return new ProfileModel()
            {
                Id = mmodel.Id,
                Nom = mmodel.Nom,
                Prenom = mmodel.Prenom,
                Surnom = mmodel.Surnom,
                Email = mmodel.Courriel
            };
        }
    }
}
