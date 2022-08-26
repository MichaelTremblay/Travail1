using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Jeu_Role
{
    internal class Mage : Personnage
    {
        //Attribut
        int bonus;

        //Contructeur
        public Mage(int xp, string nom, int poid, string sexe, int taill, int bonus)
            : base(xp, nom, poid, sexe, taill)
        {
            this.bonus = bonus;
        }
        //Destructeur
        ~Mage()
        {

        }
    }
}
