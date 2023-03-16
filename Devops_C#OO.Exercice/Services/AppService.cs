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
            foreach (KeyValuePair<string, Compte> kvp in banque.Comptes)
            {
                Console.WriteLine(kvp.Value);
                Console.WriteLine("__________________________________________");
            }
        }
        public Compte GetOne(Banque banque)
        {
            Console.Write("Numero de compte : ");
            string numero = Console.ReadLine();
            if (banque.Comptes.TryGetValue(numero, out Compte c))
            {
                return c;
            }
            throw new KeyNotFoundException();
        }

        public void Add(Banque banque)
        {
            Compte c = CompteForm(banque);
            banque.Ajouter(c);
            Console.WriteLine("Compte ajouté : ");
            Console.WriteLine(c);
        }

        public void Update(Banque banque)
        {
            GetAll(banque);
            Compte previousCompte = GetOne(banque);
            Compte newCompte = CompteForm(banque,previousCompte.Numero);
            Console.WriteLine("Vous avez modifié :");
            Console.WriteLine(previousCompte);
            Console.WriteLine("Par le compte suivant : ");
            Console.WriteLine(newCompte);
            banque[previousCompte.Numero].Numero = newCompte.Numero;
            if (banque[previousCompte.Numero] is Courant c && newCompte is Courant c2)
                c.LigneDeCredit = c2.LigneDeCredit;
            banque[previousCompte.Numero].Titulaire = newCompte.Titulaire;
        }

        public void Rechercher(Banque banque)
        {
            GetAll(banque);
            Compte c = GetOne(banque);
            Console.Clear();
            Console.WriteLine(c);
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

        public void Retrait(Compte c)
        {
            Console.Write("Montant : ");
            c.Retrait(int.Parse(Console.ReadLine()));
        }

        public void Depot(Compte c)
        {
            Console.Write("Montant : ");
            c.Depot(int.Parse(Console.ReadLine()));
        }

        public Compte CompteForm(Banque b, string? numero = null)
        {
            Console.Clear();
            Compte c;
            if (numero is null)
            {
                int choix;
                do
                {

                    Console.WriteLine("1 : Compte courant\n" +
                                      "2 : Compte épargne");
                } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > 1);
                c = choix == 1 ? new Courant() : new Epargne();
            }
            else
            {
                b.Comptes.TryGetValue(numero, out Compte prev);
                c = prev is Courant ? new Courant() : new Epargne();
            }
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
            if (c is Courant co)
                co.LigneDeCredit = decimal.Parse(Console.ReadLine());
            return c;
        }

        public void Delete(Banque banque)
        {
            GetAll(banque);
            Compte c = GetOne(banque);
            banque.Supprimer(c.Numero);
            Console.Clear();
            Console.WriteLine("Compte Supprimé : ");
            Console.WriteLine(c);
        }
    }
}
