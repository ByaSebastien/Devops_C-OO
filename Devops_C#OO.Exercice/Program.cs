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
Banque b1 = new Banque()
{
    Nom = "Belfius"
};
b1.Ajouter(c1);
b1["00001"].Depot(500);
Console.WriteLine(b1["00001"].Solde);
Console.WriteLine("__________________________");
b1["00001"].Retrait(600);
b1["00001"].Depot(1000);
Console.WriteLine(b1["00001"].Solde);
Console.WriteLine("__________________________");
foreach(KeyValuePair<string,Courant> kvp in b1.Comptes)
{
    Console.WriteLine(kvp.Key + " | " + kvp.Value.Titulaire.Prenom);
}