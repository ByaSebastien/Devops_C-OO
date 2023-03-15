using Devops_C_OO.Demo.Models;
Personnage p1 = new Personnage()
{
    Name = "Dante",
};
p1.GenerateRandomStat();
Personnage p2 = new Personnage()
{
    Name = "Vergil",
};
p2.GenerateRandomStat();
Personnage p3 = new Personnage()
{
    Name = "Toto",
};
p3.GenerateRandomStat();
Console.WriteLine(p1);
Console.WriteLine("____________________________________");
Console.WriteLine(p2);
Console.WriteLine("____________________________________");
Console.WriteLine(p1);
Console.WriteLine("____________________________________");
Console.WriteLine(p2);
Console.WriteLine("____________________________________");
Personnage fusion = p1 + p2;
fusion.Frapper(p3);
Console.WriteLine(fusion);
Console.WriteLine("____________________________________");
Console.WriteLine(p3);
Console.WriteLine("____________________________________");