using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Exercice.Models
{
    public class Banque
    {
        private Dictionary<string, Courant> _comptes = new Dictionary<string, Courant>();
        public string Nom { get; set; }
        public Dictionary<string, Courant> Comptes
        {
            get
            {
                return _comptes;
            }
        }
        public Courant this[string numero]
        {
            get
            {
                Comptes.TryGetValue(numero, out Courant c);
                return c;
            }
        }
        public void Ajouter(Courant c)
        {
            Comptes.Add(c.Numero, c);
        }
        public void Supprimer(string numero)
        {
            Comptes.Remove(numero);
        }
        public decimal AvoirDesComptes(Personne p)
        {
            decimal avoir = 0;
            foreach(KeyValuePair<string,Courant> kvp in Comptes)
            {
                if (p == kvp.Value.Titulaire)
                    avoir = avoir + kvp.Value;
            }
            return avoir;
        }
    }
}
