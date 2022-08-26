using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Jeu_Role
{
    internal class ElementDeJeu
    {
        public ElementDeJeu()
        {

        }
        ~ElementDeJeu()
        { }

        /// <summary>
        /// Affiche la ligne de texte Couocu
        /// </summary>
        public virtual void AfficheCoucou()
        {
            //Affiche Coucou
            Console.WriteLine("Coucou");
        }

        /// <summary>
        /// Affiche la ligne de texte totp
        /// </summary>
        public virtual void AfficheToto()
        {
            //Affiche Toto
            Console.WriteLine("Coucou");
        }

    }
}
