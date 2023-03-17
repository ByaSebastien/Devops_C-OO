using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Demo.Utils
{
    public enum DiceType
    {
        D4 = 4,
        D6 = 6,
        D8 = 8,
        D10 = 10,
        D12 = 12,
        D20 = 20,
        D100 = 100,
    }
    public static class Dice
    {
        public static int Throws(DiceType dice, int nbThrow = 1,int nbToKeep = 1)
        {
            Random rnd = new Random();
            List<int> throws = new List<int>();
            for(int i = 0; i < nbThrow; i++)
            {
                throws.Add(rnd.Next((int)dice) + 1);
            }
            return throws.OrderByDescending(x => x).Take(nbToKeep).Sum();
        }
    }
}
