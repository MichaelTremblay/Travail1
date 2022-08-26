using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Jeu_Role
{
    internal class Personnage : ElementDeJeu
    {
        public int charisma;
        public int constitution;
        public int dexterity;
        public int intelligence;
        public int strenght;
        public int wisdom;
        Random rand;
        int experience
        { get; set; }
        string nom
        { get; set; }
        int poid
        { get; set; }
        string sexe
        { get; set; }
        int taille
        { get; set; }   

        public Personnage(int sonExp, string sonNom, int sonPoid, string sonSexe, int saTaille)
        {
            experience = sonExp;
            nom = sonNom;   
            poid = sonPoid;
            sexe = sonSexe;
            taille = saTaille;
        }

        ~Personnage()
        { }

        /// <summary>
        /// Affiche les stats d'un perso.
        /// </summary>
        public virtual void AfficheStat()
        {
            Console.WriteLine("Affiche stats");
        }



    }
}
