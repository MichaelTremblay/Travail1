using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Jeu_Role
{
    internal class Pretre : Personnage
    {
        //Attribut
        int bonus;

        //Constructeur
        public Pretre(int xp, string nom, int poid, string sexe, int taille, int bonus)
            : base(xp, nom, poid, sexe, taille)
        {
            this.bonus = bonus;
        }

        /// <summary>
        /// Affiche Coucou et qu'il est dangereux.
        /// </summary>
        public override void AfficheCoucou()
        {
            base.AfficheCoucou();
            Console.WriteLine("Je suis un dangereux pretre");
        }


    }
}
