using Devops_C_OO.Demo.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Demo.Models
{
    public abstract class Personnage
    {
        public static int CurrentId = 1;
        public Personnage() 
        { 
            Id = CurrentId++;
        }
        public int Id { get; set; }
        public int Pv
        {
            get
            {
                return Stats[StatType.Pv];
            }
        } 
        public Stats Stats { get; set; } = new Stats();


        public abstract void Frapper(Personnage p);

        public void GenerateRandomStat()
        {
            Random random = new Random();
            Stats[StatType.Pv] = Dice.Throws(DiceType.D10,5,3);
            Stats[StatType.Force] = Dice.Throws(DiceType.D10, 5, 3);
            Stats[StatType.Defence] = Dice.Throws(DiceType.D10, 5, 3);
            Stats[StatType.Vitesse] = Dice.Throws(DiceType.D10, 5, 3);
        }

        

        public override string ToString()
        {
            return $"Pv : {Pv}\n" +
                   $"Force : {Stats[StatType.Force]}\n" +
                   $"Defence : {Stats[StatType.Defence]}\n" +
                   $"Vitesse : {Stats[StatType.Vitesse]}\n" +
                   $"Id : {Id}\n";
        }
    }
}
