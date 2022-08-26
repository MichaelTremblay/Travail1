using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Jeu_Role
{
    internal class Guerrier : Personnage
    {
        //Attribut
        int bonus;

        //Constructeur
        public Guerrier(int xp, string nom, int poind, string sexe, int taille, int bonus)
            :base(xp, nom, poind, sexe, taille)
        {
            this.bonus = bonus;
        }

        //Destructeur
        ~Guerrier()
        {

        }
        /// <summary>
        /// Affiche les stats et qu'il est dangereux.
        /// </summary>
        public override void AfficheStat()
        {
            base.AfficheStat();
            Console.WriteLine("J'suis un guerrier fort!");
        }
    }
}
