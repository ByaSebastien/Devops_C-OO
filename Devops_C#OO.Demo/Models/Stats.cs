﻿using Devops_C_OO.Demo.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Demo.Models
{
    public enum StatType
    {
        Pv,
        Force,
        Defence,
        Vitesse,
    }
    public class Stats
    {
        private Dictionary<StatType, int> _stats;
        public Dictionary<StatType, int> StatList
        {
            get { return _stats = _stats ?? new Dictionary<StatType, int>(); }
        }
        public int this[StatType type]
        {
            get
            {
                if (!StatList.TryGetValue(type, out int stat))
                    return 0;
                return stat;
            }
            set
            {
                if (value < 0)
                    StatList[type] = 0;
                else
                {
                    if (!StatList.ContainsKey(type))
                        StatList.Add(type, 0);
                    StatList[type] = value;
                }
            }
        }
    }
}
