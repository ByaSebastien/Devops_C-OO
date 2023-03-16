using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Exercice.Models
{
    public class Epargne : Compte
    {
        #region Propriétés

        public DateTime DateDernierRetrait { get; set; }

        #endregion

        #region Methodes

        public override void Retrait(decimal montant)
        {
            decimal soldePrecedent = Solde;
            base.Retrait(montant);
            if (soldePrecedent != Solde)
                DateDernierRetrait = DateTime.Now;
        }

        #endregion
    }
}
