using Devops_C_OO.Demo.Extentions;
using Devops_C_OO.Demo.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Demo.Models
{
    public class Hero : Personnage
    {
        public string Name { get; set; }
        public void SeSoigner()
        {
            Stats[StatType.Pv] += 10;
        }
        public override void Frapper(Personnage p)
        {
            Console.WriteLine($"{Name} attaque");
            p.Stats[StatType.Pv] -= Stats[StatType.Force] + Dice.Throws(DiceType.D6);
        }
        public static Hero operator +(Hero p1, Hero p2)
        {
            Console.WriteLine("Fuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu Sion!");
            Hero fusion = new Hero();
            fusion.Name = p1.Name.ConcatFusion(p2.Name);
            fusion.Stats[StatType.Pv] = p1.Stats[StatType.Pv] + p2.Stats[StatType.Pv];
            fusion.Stats[StatType.Force] = p1.Stats[StatType.Force] + p2.Stats[StatType.Force];
            fusion.Stats[StatType.Defence] = p1.Stats[StatType.Defence] + p2.Stats[StatType.Defence];
            fusion.Stats[StatType.Vitesse] = p1.Stats[StatType.Vitesse] + p2.Stats[StatType.Vitesse];
            return fusion;
        }
        public override string ToString()
        {
            return $"{Name}:\n" + base.ToString();
        }
    }
}
