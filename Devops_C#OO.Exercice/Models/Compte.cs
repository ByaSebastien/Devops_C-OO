using Devops_C_OO.Exercice.Exceptions;
using Devops_C_OO.Exercice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Exercice.Models
{
    public delegate void PassageEnNegatifDelegate(Compte c);
    public abstract class Compte : IBanker,ICustomer
    {
        public event Action<Compte> PassageEnNegatifEvent;
        public event Action SoldeCritiqueEvent;
        #region Propriétés
        public string Numero { get; private set; }
        public decimal Solde { get; private set; }
        public Personne Titulaire { get; private set; }


        #endregion

        #region Constructeurs

        public Compte(string numero, Personne titulaire)
        {
            Numero = numero;
            Titulaire = titulaire;
            SoldeCritiqueEvent += Alert;
        }
        public Compte(string numero, Personne titulaire, decimal solde) : this(numero, titulaire)
        {
            Solde = solde;
        }


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
            if (montant < 0)
                throw new ArgumentOutOfRangeException("Le montant ne peut être négatif");
            if (Solde - montant < -ligneDeCredit)
                throw new SoldeInsuffisantException();
            Solde -= montant;
            if(Solde < 10)
            {
                RaiseSoldeCritiqueEvent();
            }

        }

        /// <summary>
        /// Cette méthode permet d'ajouter un montant au solde du compte
        /// </summary>
        /// <param name="montant">Le montant a ajouter du solde</param>
        public void Depot(decimal montant)
        {
            if (montant < 0)
                throw new ArgumentOutOfRangeException("Le montant ne peut être négatif");
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
        public void Alert()
        {
            Console.WriteLine("Solde critique");
        }
        public void RaiseSoldeCritiqueEvent()
        {
            SoldeCritiqueEvent?.Invoke();
        }
        public void RaisePassageEnNegatifEvent()
        {
            PassageEnNegatifEvent?.Invoke(this);
        }
    }
}
