using Devops_C_OO.Exercice.Models;

Personne p1 = new Personne()
{
    Nom = "Bya",
    Prenom = "Sébastien",
    DateNaiss = new DateTime(1991, 3, 27),
};
Courant c1 = new Courant()
{
    Numero = "00001",
    LigneDeCredit = 100,
    Titulaire = p1
};
Console.WriteLine(c1.LigneDeCredit);
c1.Depot(500);
Console.WriteLine(c1.Solde);
Console.WriteLine("__________________________");
c1.Retrait(600);
c1.Depot(1000);
Console.WriteLine(c1.Solde);
Console.WriteLine("__________________________");
