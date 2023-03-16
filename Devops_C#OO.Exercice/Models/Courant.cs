using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Exercice.Models
{
    public class Courant : Compte
    {
        #region Attributs

        private decimal _ligneDeCredit;

        #endregion

        #region Propriétés

        public decimal LigneDeCredit 
        {
            get 
            { 
                return _ligneDeCredit; 
            }
            set
            {
                if (value < 0)
                    return;
                _ligneDeCredit = value;
            }
        }

        #endregion

        #region Méthodes

        public override void Retrait(decimal montant)
        {
            base.Retrait(montant,LigneDeCredit);
        }
        public override string ToString()
        {
            return base.ToString() + $"\nLigne de crédit : {LigneDeCredit}";
        }

        protected override decimal CalculInteret()
        {
            return Solde * (Solde < 0 ? .0975M : .03M);
        }

        #endregion
    }
}
