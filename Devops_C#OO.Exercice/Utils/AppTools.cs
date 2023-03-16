using Devops_C_OO.Exercice.Datas;
using Devops_C_OO.Exercice.Models;
using Devops_C_OO.Exercice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Exercice.Utils
{
    public class AppTools
    {
        private AppService _appService = new AppService();
        public void Start()
        {
            FakeDb.InitDb();
            Banque? banque;
            int choixBanque = Menu(Menus.BankMenu, 3);
            switch (choixBanque)
            {
                case 0:
                    Console.WriteLine("Au revoir.");
                    return;
                case 1:
                    banque = FakeDb.Belfius;
                    break;
                case 2:
                    banque = FakeDb.BNP;
                    break;
                case 3:
                    banque = FakeDb.Argenta;
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
                        _appService.GetAll(banque);
                        break;
                    case 2:
                        _appService.Rechercher(banque);
                        break;
                    case 3:
                        _appService.Add(banque);
                        break;
                    case 4:
                        _appService.Update(banque);
                        break;
                    case 5:
                        _appService.Delete(banque);
                        break;
                    default:
                        Console.WriteLine("Error.");
                        return;
                }
                Console.ReadKey();
            } while (choixCrud != 0);
        }
        public static int Menu(string menu, int limit)
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
