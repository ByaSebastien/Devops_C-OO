using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Exercice.Models
{
    public class Courant
    {
        #region Attributs

        private decimal _ligneDeCredit;

        #endregion

        #region Propriétés

        public string Numero { get; set; }
        public decimal Solde { get; private set; }
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
        public Personne Titulaire { get; set; }

        #endregion

        #region Méthodes

        /// <summary>
        /// Cette méthode permet de retirer un montant au solde du compte
        /// </summary>
        /// <param name="montant">Le montant a retirer du solde</param>
        public void Retrait(decimal montant)
        {
            if(montant < 0)
                return;
            if(Solde + LigneDeCredit < montant) 
                return;
            Solde -= montant;
        }

        /// <summary>
        /// Cette méthode permet d'ajouter un montant au solde du compte
        /// </summary>
        /// <param name="montant">Le montant a ajouter du solde</param>
        public void Depot(decimal montant)
        {
            if(montant < 0)
                return;
            Solde += montant;
        }

        public static decimal operator +(decimal solde,Courant c)
        {
            if (c is null) 
                return solde;
            return solde + (c.Solde < 0 ? 0 : c.Solde);
        }
        #endregion
    }
}
