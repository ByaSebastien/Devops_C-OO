﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Demo.Models
{
    public class Personnage
    {
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Name { get; set; }
        public Stats Stats { get; set; } = new Stats();


        public void Frapper(Personnage p)
        {
            Console.WriteLine($"{Name} attaque {p.Name}");
            p.Stats[StatType.Pv] -= Stats[StatType.Force];
        }

    }
}
