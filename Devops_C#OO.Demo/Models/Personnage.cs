using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Demo.Models
{
    public class Personnage
    {
        public string Name { get; set; }
        public int Pv
        {
            get
            {
                return Stats[StatType.Pv];
            }
        } 
        public Stats Stats { get; set; } = new Stats();


        public void Frapper(Personnage p)
        {
            Console.WriteLine($"{Name} attaque {p.Name}");
            p.Stats[StatType.Pv] -= Stats[StatType.Force];
        }

        public void GenerateRandomStat()
        {
            Random random = new Random();
            Stats[StatType.Pv] = random.Next(10,20);
            Stats[StatType.Force] = random.Next(20, 25);
            Stats[StatType.Defence] = random.Next(5, 15);
            Stats[StatType.Vitesse] = random.Next(10, 50);
        }

        public static Personnage operator +(Personnage p1, Personnage p2)
        {
            Console.WriteLine("Fuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu Sion!");
            Personnage fusion = new Personnage();
            fusion.Name = p1.Name.Substring(0,2) + p2.Name.Substring(p2.Name.Length - 2,2);
            fusion.Stats[StatType.Pv] = p1.Stats[StatType.Pv] + p2.Stats[StatType.Pv];
            fusion.Stats[StatType.Force] = p1.Stats[StatType.Force] + p2.Stats[StatType.Force];
            fusion.Stats[StatType.Defence] = p1.Stats[StatType.Defence] + p2.Stats[StatType.Defence];
            fusion.Stats[StatType.Vitesse] = p1.Stats[StatType.Vitesse] + p2.Stats[StatType.Vitesse];
            return fusion;
        }

        public override string ToString()
        {
            return $"{Name}:\n" +
                   $"Pv : {Pv}\n" +
                   $"Force : {Stats[StatType.Force]}\n" +
                   $"Defence : {Stats[StatType.Defence]}\n" +
                   $"Vitesse : {Stats[StatType.Vitesse]}\n";
        }
    }
}
