using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Exercice.Models
{
    public abstract class Compte
    {
        #region Propriétés

        public string Numero { get; set; }
        public decimal Solde { get; private set; }
        public Personne Titulaire { get; set; }

        #endregion

        #region Méthodes

        /// <summary>
        /// Cette méthode permet de retirer un montant au solde du compte
        /// </summary>
        /// <param name="montant">Le montant a retirer du solde</param>
        public virtual void Retrait(decimal montant)
        {
            Retrait(montant, 0);
        }
        public void Retrait(decimal montant, decimal ligneDeCredit)
        {
            if(montant <= 0)
                return;
            if (Solde - montant < -ligneDeCredit)
                return;
            Solde -= montant;
        }

        /// <summary>
        /// Cette méthode permet d'ajouter un montant au solde du compte
        /// </summary>
        /// <param name="montant">Le montant a ajouter du solde</param>
        public void Depot(decimal montant)
        {
            if (montant < 0)
                return;
            Solde += montant;
        }

        protected abstract decimal CalculInteret();

        public void AppliquerInteret()
        {
            Solde += CalculInteret();
        }

        public static decimal operator +(decimal solde, Compte c)
        {
            if (c is null)
                return solde;
            return solde + (c.Solde < 0 ? 0 : c.Solde);
        }

        public override string ToString()
        {
            return $"Titulaire : {Titulaire.Nom} {Titulaire.Prenom}\n" +
                   $"Numero de compte : {Numero}\n" +
                   $"Solde : {Solde}";
        }
        #endregion
    }
}
