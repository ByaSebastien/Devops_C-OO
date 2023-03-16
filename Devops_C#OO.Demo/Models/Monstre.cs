using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Devops_C_OO.Demo.Models
{
    public class Monstre : Personnage
    {
        public string Race { get; set; }
        public override void Frapper(Personnage p)
        {
            Console.WriteLine("aaaaaaaaaaaaaah");
            int result = Stats[StatType.Force] - p.Stats[StatType.Defence];
            p.Stats[StatType.Pv] -= (result <= 0 ? 1 : result);
        }
        public override string ToString()
        {
            return $"{Race}:\n" + base.ToString();
        }
    }
}
