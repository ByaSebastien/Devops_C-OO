using Devops_C_OO.Exercice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Exercice.Datas
{
    public static class FakeDb
    {
        public static Banque Belfius = new Banque()
        {
            Nom = "Belfius",
        };
        public static Banque BNP = new Banque()
        {
            Nom = "BNP Paribas",
        };
        public static Banque Argenta = new Banque()
        {
            Nom = "Argenta",
        };
        public static void InitDb()
        {
            Belfius.Ajouter(new Courant(new Personne("Sébastien", "Bya", new DateTime(1991, 3, 27)), "00001", 100));
            Belfius.Comptes["00001"].Depot(500);
            Belfius.Ajouter(new Courant(new Personne("Jean", "Neymar", new DateTime(1985, 5, 12)), "00002", 500));
            Belfius.Comptes["00002"].Depot(1500);
            Belfius.Ajouter(new Courant(new Personne("Baptiste", "Pasnet", new DateTime(1999, 9, 14)), "00003", 1000));
            Belfius.Comptes["00003"].Depot(100);
            Belfius.Ajouter(new Courant(new Personne("Sébastien", "Bya", new DateTime(1991, 3, 27)), "00004", 1000));
            Belfius.Comptes["00004"].Depot(100);
            BNP.Ajouter(new Courant(new Personne("Sébastien", "Bya", new DateTime(1991, 3, 27)), "00005", 100));
            BNP.Comptes["00005"].Depot(500);
            BNP.Ajouter(new Courant(new Personne("Jean", "Neymar", new DateTime(1985, 5, 12)), "00006", 500));
            BNP.Comptes["00006"].Depot(1500);
            BNP.Ajouter(new Courant(new Personne("Baptiste", "Pasnet", new DateTime(1999, 9, 14)), "00007", 1000));
            BNP.Comptes["00007"].Depot(100);
            Argenta.Ajouter(new Courant(new Personne("Sébastien", "Bya", new DateTime(1991, 3, 27)), "00008", 100));
            Argenta.Comptes["00008"].Depot(500);
            Argenta.Ajouter(new Courant(new Personne("Jean", "Neymar", new DateTime(1985, 5, 12)), "00009", 500));
            Argenta.Comptes["00009"].Depot(1500);
            Argenta.Ajouter(new Courant(new Personne("Baptiste", "Pasnet", new DateTime(1999, 9, 14)), "00010", 1000));
            Argenta.Comptes["00010"].Depot(100);
        }
    }
}
