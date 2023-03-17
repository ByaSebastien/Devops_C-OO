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

        public void Rechercher(Banque banque)
        {
            GetAll(banque);
            Compte c = GetOne(banque);
            Console.Clear();
            Console.WriteLine(c);
            int choix;
            do
            {

                choix = AppTools.Menu(Menus.MouvementMenu, 3, false);
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
                    case 3:
                        c.AppliquerInteret();
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                Console.Clear();
                Console.WriteLine(c);
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
            int choix;
            do
            {

                Console.WriteLine("1 : Compte courant\n" +
                                  "2 : Compte épargne");
            } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > 2);
            Console.WriteLine("Titulaire du compte : ");
            Console.Write("Nom : ");
            string nom = Console.ReadLine();
            Console.Write("Prenom : ");
            string prenom = Console.ReadLine();
            Console.WriteLine("Date de naissance");
            Console.Write("Jour : ");
            int jour = int.Parse(Console.ReadLine());
            Console.Write("Mois : ");
            int mois = int.Parse(Console.ReadLine());
            Console.Write("Année : ");
            int annee = int.Parse(Console.ReadLine());
            DateTime dateNaiss = new DateTime(annee, mois, jour);
            Personne t = new Personne(prenom, nom, dateNaiss);
            Console.Write("Numéro de compte : ");
            string newNumero = Console.ReadLine();
            if (choix == 1)
            {
                Console.Write("Ligne de crédit : ");
                decimal ligneDeCredit = decimal.Parse(Console.ReadLine());
                c = new Courant(t, newNumero, ligneDeCredit);
            }
            else
                c = new Epargne(newNumero, t);
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
