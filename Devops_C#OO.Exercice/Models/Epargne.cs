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

        public DateTime DateDernierRetrait { get; private set; }


        #endregion

        #region Constructeurs

        public Epargne(string numero, Personne titulaire) : this(numero, titulaire, 0) { }
        public Epargne(string numero, Personne titulaire, decimal solde) : base(numero, titulaire, solde) 
        {
            DateDernierRetrait = DateTime.Now;
        }

        #endregion

        #region Methodes

        public override void Retrait(decimal montant)
        {
            decimal soldePrecedent = Solde;
            base.Retrait(montant);
            if (soldePrecedent != Solde)
                DateDernierRetrait = DateTime.Now;
        }
        protected override decimal CalculInteret()
        {
            return Solde * .045M;
        }

        #endregion
    }
}
