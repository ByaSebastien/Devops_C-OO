using Devops_C_OO.Exercice.Datas;
using Devops_C_OO.Exercice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Exercice.Utils
{
    public class AppTools
    {
        public void Start()
        {
            FakeDb db = new FakeDb();
            db.InitDb();
            Banque? banque;
            int choixBanque = Menu(Menus.BankMenu, 3);
            switch (choixBanque)
            {
                case 0:
                    Console.WriteLine("Au revoir.");
                    return;
                case 1:
                    banque = db.Belfius;
                    break;
                case 2:
                    banque = db.BNP;
                    break;
                case 3:
                    banque = db.Argenta;
                    break;
                default:
                    Console.WriteLine("Error.");
                    return;
            }
            Console.WriteLine(banque);
            int choixCrud;
            do
            {
                choixCrud = Menu(Menus.CrudMenu, 5);
                switch (choixCrud)
                {
                    case 0:
                        Console.WriteLine("Au revoir.");
                        return;
                    case 1:
                        foreach (KeyValuePair<string, Courant> kvp in banque.Comptes)
                        {
                            Console.WriteLine(kvp.Key + " : " + kvp.Value.Titulaire.Prenom);
                            Console.WriteLine("__________________________________________");
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Error.");
                        return;
                }
            } while (choixCrud != 0);
        }
        public int Menu(string menu, int limit)
        {
            int choix;
            do
            {
                Console.Clear();
                Console.WriteLine(menu);
            } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 0 || choix > limit);
            Console.Clear();
            return choix;
        }
    }
}
