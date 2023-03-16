using Devops_C_OO.Exercice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Exercice.Datas
{
    public class FakeDb
    {
        public Banque Belfius = new Banque()
        {
            Nom = "Belfius",
        };
        public Banque BNP = new Banque()
        {
            Nom = "BNP Paribas",
        };
        public Banque Argenta = new Banque()
        {
            Nom = "Argenta",
        };
        public void InitDb()
        {
            Belfius.Ajouter(new Courant()
            {
                Numero = "00001",
                LigneDeCredit = 100,
                Titulaire = new Personne()
                {
                    Prenom = "Sébastien",
                    Nom = "Bya",
                    DateNaiss = new DateTime(1991, 3, 27)
                }
            });
            Belfius.Comptes["00001"].Depot(500);
            Belfius.Ajouter(new Courant()
            {
                Numero = "00002",
                LigneDeCredit = 500,
                Titulaire = new Personne()
                {
                    Prenom = "Jean",
                    Nom = "Neymar",
                    DateNaiss = new DateTime(1985, 5, 12)
                }
            });
            Belfius.Comptes["00002"].Depot(1500);
            Belfius.Ajouter(new Courant()
            {
                Numero = "00003",
                LigneDeCredit = 1000,
                Titulaire = new Personne()
                {
                    Prenom = "Baptiste",
                    Nom = "Pasnet",
                    DateNaiss = new DateTime(1999, 9, 14)
                }
            });
            Belfius.Comptes["00003"].Depot(100);
            Belfius.Ajouter(new Courant()
            {
                Numero = "00004",
                LigneDeCredit = 1000,
                Titulaire = new Personne()
                {
                    Prenom = "Sébastien",
                    Nom = "Bya",
                    DateNaiss = new DateTime(1991, 3, 27)
                }
            });
            Belfius.Comptes["00004"].Depot(100);
            BNP.Ajouter(new Courant()
            {
                Numero = "00005",
                LigneDeCredit = 100,
                Titulaire = new Personne()
                {
                    Prenom = "Sébastien",
                    Nom = "Bya",
                    DateNaiss = new DateTime(1991, 3, 27)
                }
            });
            BNP.Comptes["00005"].Depot(500);
            BNP.Ajouter(new Courant()
            {
                Numero = "00006",
                LigneDeCredit = 500,
                Titulaire = new Personne()
                {
                    Prenom = "Jean",
                    Nom = "Neymar",
                    DateNaiss = new DateTime(1985, 5, 12)
                }
            });
            BNP.Comptes["00006"].Depot(1500);
            BNP.Ajouter(new Courant()
            {
                Numero = "00007",
                LigneDeCredit = 1000,
                Titulaire = new Personne()
                {
                    Prenom = "Baptiste",
                    Nom = "Pasnet",
                    DateNaiss = new DateTime(1999, 9, 14)
                }
            });
            BNP.Comptes["00007"].Depot(100);
            Argenta.Ajouter(new Courant()
            {
                Numero = "00008",
                LigneDeCredit = 100,
                Titulaire = new Personne()
                {
                    Prenom = "Sébastien",
                    Nom = "Bya",
                    DateNaiss = new DateTime(1991, 3, 27)
                }
            });
            Argenta.Comptes["00008"].Depot(500);
            Argenta.Ajouter(new Courant()
            {
                Numero = "00009",
                LigneDeCredit = 500,
                Titulaire = new Personne()
                {
                    Prenom = "Jean",
                    Nom = "Neymar",
                    DateNaiss = new DateTime(1985, 5, 12)
                }
            });
            Argenta.Comptes["00009"].Depot(1500);
            Argenta.Ajouter(new Courant()
            {
                Numero = "00010",
                LigneDeCredit = 1000,
                Titulaire = new Personne()
                {
                    Prenom = "Baptiste",
                    Nom = "Pasnet",
                    DateNaiss = new DateTime(1999, 9, 14)
                }
            });
            Argenta.Comptes["00010"].Depot(100);
        }
    }
}
