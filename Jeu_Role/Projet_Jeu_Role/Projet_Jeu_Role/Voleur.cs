using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Jeu_Role
{
    internal class Voleur : Personnage
    {
        int bonus;
        public Voleur (int xp, string nom, int poid, string sexe, int taille, int bonus)
             : base(xp, nom, poid, sexe, taille)
        {
            this.bonus = bonus;
        }

        ~Voleur()
        { }

        public override void AfficheCoucou()
        {
            base.AfficheCoucou();
            Console.WriteLine("Je suis un dangereux voleur");
        }
        public override void AfficheStat()
        {
            base.AfficheStat();
            Console.WriteLine("J'suis un voleur fort!");
        }
        public override void AfficheToto()
        {
            base.AfficheToto();
            Console.WriteLine("J'suis un voleur discret!");
        }
    }
}
