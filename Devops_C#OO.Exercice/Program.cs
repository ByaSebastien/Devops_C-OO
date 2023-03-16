using Devops_C_OO.Exercice.Models;
using Devops_C_OO.Exercice.Utils;

Personne p1 = new Personne()
{
    Nom = "Bya",
    Prenom = "Sébastien",
    DateNaiss = new DateTime(1991, 3, 27),
};
Personne p2 = new Personne()
{
    Nom = "Vandam",
    Prenom = "Jeau Claude",
    DateNaiss = new DateTime(1965, 3, 27),
};
Personne p3 = new Personne()
{
    Nom = "Bya",
    Prenom = "Sébastien",
    DateNaiss = new DateTime(1991, 3, 27),
};
Personne p4 = null;
Courant c1 = new Courant()
{
    Numero = "00001",
    LigneDeCredit = 100,
    Titulaire = p1
};
Courant c2 = new Courant()
{
    Numero = "00002",
    LigneDeCredit = 100,
    Titulaire = p3
};
Courant c3 = new Courant()
{
    Numero = "00003",
    LigneDeCredit = 100,
    Titulaire = p2
};
Banque b1 = new Banque()
{
    Nom = "Belfius"
};
b1.Ajouter(c1);
b1.Ajouter(c2);
b1.Ajouter(c3);
b1["00001"].Depot(500);
b1["00002"].Depot(1500);
b1["00003"].Depot(5000);
Console.WriteLine(b1.AvoirDesComptes(p1));
Console.WriteLine(p1 == p4);




//AppTools app =  new AppTools();
//app.Start();