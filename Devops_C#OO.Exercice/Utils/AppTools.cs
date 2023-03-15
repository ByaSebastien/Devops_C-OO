using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Exercice.Utils
{
    public static class AppTools
    {
        public static void Start()
        {
            int choix;
            StringBuilder menu = new StringBuilder();
            menu.AppendLine("0 : Quitter");
            menu.AppendLine("1 : Belfius");
            menu.AppendLine("2 : BNP Paribas");
            menu.AppendLine("3 : Argenta");
            do
            {
                Console.Clear();
                Console.WriteLine(menu);
            } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 0 || choix > 3);
            StringBuilder menuCRUD = new StringBuilder();
            menuCRUD.AppendLine("0 : Quitter");
            menuCRUD.AppendLine("1 : Lister");
            menuCRUD.AppendLine("2 : Rechercher");
            menuCRUD.AppendLine("3 : Ajouter");
            menuCRUD.AppendLine("4 : Modifier");
            menuCRUD.AppendLine("5 : Supprimer");
            do
            {
                Console.Clear();
                Console.WriteLine(menuCRUD);
            } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 0 || choix > 5);
        }
        public static void Menu(StringBuilder menu)
        {
            //menu.Length;
        }
    }
}
