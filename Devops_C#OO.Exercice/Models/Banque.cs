using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Exercice.Models
{
    public class Banque
    {
        private Dictionary<string, Compte> _comptes = new Dictionary<string, Compte>();
        public string Nom { get; set; }
        public Dictionary<string, Compte> Comptes
        {
            get
            {
                return _comptes;
            }
        }
        public Compte this[string numero]
        {
            get
            {
                Comptes.TryGetValue(numero, out Compte c);
                return c;
            }
        }
        public void Ajouter(Compte c)
        {
            Comptes.Add(c.Numero, c);
            c.PassageEnNegatifEvent += PassageEnNegatifAction;
        }
        public void Supprimer(string numero)
        {
            Comptes.Remove(numero);
        }
        public decimal AvoirDesComptes(Personne p)
        {
            decimal avoir = 0;
            foreach(KeyValuePair<string,Compte> kvp in Comptes)
            {
                if (p == kvp.Value.Titulaire)
                    avoir = avoir + kvp.Value;
            }
            return avoir;
        }
        private void PassageEnNegatifAction(Compte c)
        {
            Console.WriteLine($"Le compte numero {c.Numero} est passé en négatif.");
        }
    }
}
