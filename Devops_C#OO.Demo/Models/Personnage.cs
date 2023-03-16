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
            Stats[StatType.Pv] = random.Next(10,20);
            Stats[StatType.Force] = random.Next(20, 25);
            Stats[StatType.Defence] = random.Next(5, 15);
            Stats[StatType.Vitesse] = random.Next(10, 50);
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
