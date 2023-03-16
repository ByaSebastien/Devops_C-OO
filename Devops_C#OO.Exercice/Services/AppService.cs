using Devops_C_OO.Exercice.Models;
using Devops_C_OO.Exercice.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Exercice.Services
{
    public class AppService
    {
        public void GetAll(Banque banque)
        {
            foreach (KeyValuePair<string, Courant> kvp in banque.Comptes)
            {
                Console.WriteLine(kvp.Key + " : " + kvp.Value.Titulaire.Prenom);
                Console.WriteLine("__________________________________________");
            }
        }
        public Courant GetOne(Banque banque)
        {
            Console.Write("Numero de compte : ");
            string numero = Console.ReadLine();
            if (banque.Comptes.TryGetValue(numero, out Courant c))
            {
                return c;
            }
            throw new KeyNotFoundException();
        }

        public void Add(Banque banque)
        {
            Courant c = CompteForm();
            banque.Ajouter(c);
            Console.WriteLine("Compte ajouté : " + c.Numero + " : " + c.Titulaire.Prenom);
        }

        public void Update(Banque banque)
        {
            GetAll(banque);
            Courant previousCourant = GetOne(banque);
            Courant newCourant = CompteForm(previousCourant.Numero);
            Console.WriteLine("Vous avez modifié :");
            Console.WriteLine(previousCourant.Numero + " : " + previousCourant.Titulaire.Prenom);
            Console.WriteLine("Par le compte suivant : ");
            Console.WriteLine(newCourant.Numero + " : " + newCourant.Titulaire.Prenom);
            banque[previousCourant.Numero].Numero = newCourant.Numero;
            banque[previousCourant.Numero].LigneDeCredit = newCourant.LigneDeCredit;
            banque[previousCourant.Numero].Titulaire = newCourant.Titulaire;
        }

        public void Rechercher(Banque banque)
        {
            GetAll(banque);
            Courant c = GetOne(banque);
            Console.WriteLine(c.Numero + " : " + c.Titulaire.Prenom);
            Console.ReadKey();
            int choix;
            do
            {

                choix = AppTools.Menu(Menus.MouvementMenu, 2);
                switch (choix)
                {
                    case 0:
                        Console.WriteLine("Retour au menu");
                        return;
                    case 1:
                        Depot(c);
                        break;
                    case 2:
                        Retrait(c);
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            } while (choix != 0);
        }

        public void Retrait(Courant c)
        {
            Console.Write("Montant : ");
            c.Retrait(int.Parse(Console.ReadLine()));
        }

        public void Depot(Courant c)
        {
            Console.Write("Montant : ");
            c.Depot(int.Parse(Console.ReadLine()));
        }

        public Courant CompteForm(string? numero = null)
        {
            Console.Clear();
            Courant c = new Courant();
            Personne t = new Personne();
            Console.WriteLine("Titulaire du compte : ");
            Console.Write("Nom : ");
            t.Nom = Console.ReadLine();
            Console.Write("Prenom : ");
            t.Prenom = Console.ReadLine();
            Console.WriteLine("Date de naissance");
            Console.Write("Jour : ");
            int jour = int.Parse(Console.ReadLine());
            Console.Write("Mois : ");
            int mois = int.Parse(Console.ReadLine());
            Console.Write("Année : ");
            int annee = int.Parse(Console.ReadLine());
            t.DateNaiss = new DateTime(annee, mois, jour);
            c.Titulaire = t;
            if (numero is null)
            {
                Console.Write("Numéro de compte : ");
                c.Numero = Console.ReadLine();
            }
            else
                c.Numero = numero;
            Console.Write("Ligne de crédit : ");
            c.LigneDeCredit = decimal.Parse(Console.ReadLine());
            return c;
        }

        public void Delete(Banque banque)
        {
            GetAll(banque);
            Courant c = GetOne(banque);
            banque.Supprimer(c.Numero);
            Console.WriteLine("Compte Supprimé : " + c.Numero + " : " + c.Titulaire.Prenom);
        }
    }
}
