using Devops_C_OO.Exercice.Exceptions;
using Devops_C_OO.Exercice.Models;


//AppTools app = new AppTools();
//app.Start();
try
{
    Courant c = new Courant(new Personne("Sébastien", "Bya", new DateTime(1991, 3, 27)), "00001", 100);
    Banque b = new Banque();
    b.Nom = "Belfius";
    b.Ajouter(c);
    c.Depot(100);
    c.Retrait(150);
}
catch(ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch(InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}
catch(SoldeInsuffisantException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception)
{
    throw;
}