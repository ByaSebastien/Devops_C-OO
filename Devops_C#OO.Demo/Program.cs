using Devops_C_OO.Demo.Models;
List<Personnage> personnages = new List<Personnage>()
{
    new Hero()
    {
        Name = "Dante",
    },
    new Monstre()
    {
        Race = "Toto le malefique",
    },
    new Hero()
    {
        Name = "Vergil",
    },
};
Monstre boss = new Monstre();
boss.Race = "Le mechant";
boss.Stats[StatType.Pv] = 100;
boss.Stats[StatType.Force] = 100;
boss.Stats[StatType.Defence] = 100;
boss.Stats[StatType.Vitesse] = 100;
foreach (Personnage p in personnages)
{
    p.GenerateRandomStat();
    Console.WriteLine(p);
    p.Frapper(boss);
    Console.WriteLine("_______________________________________");
    //switch (p)
    //{
    //    case Hero h:
    //        h.SeSoigner();
    //        break;
    //    case Monstre m:
    //        m.Frapper(m);
    //        Console.WriteLine("aaaaaaaaaaaaaa");
    //        break;
    //}
}
personnages.Add((Hero)personnages[0] + (Hero)personnages[2]);
Console.WriteLine(personnages[3]);
Console.WriteLine(boss);
Console.WriteLine(Personnage.CurrentId);