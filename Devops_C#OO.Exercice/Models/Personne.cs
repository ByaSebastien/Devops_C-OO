using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Exercice.Models
{
    public class Personne
    {
        #region Propriétés
        public string Nom {  get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaiss { get; set; }
        #endregion
        public static bool operator ==(Personne p1,Personne p2)
        {
            if (p1 is null || p2 is null)
                return false;
            return p1.Nom == p2.Nom && p1.Prenom == p2.Prenom && p1.DateNaiss == p2.DateNaiss;
        }
        public static bool operator !=(Personne p1, Personne p2)
        {
            return !(p1 == p2);
        }
    }
}
