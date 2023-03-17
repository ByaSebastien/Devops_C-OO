using Devops_C_OO.Demo.Models;
List<Personnage> personnages = new List<Personnage>()
{
    new Hero("Dante"),
    new Monstre("Toto le malefique"),
    new Hero("Vergil"),
};
Monstre boss = new Monstre("Le mechant");
boss.Stats[StatType.Pv] = 100;
boss.Stats[StatType.Force] = 100;
boss.Stats[StatType.Defence] = 100;
boss.Stats[StatType.Vitesse] = 100;
foreach (Personnage p in personnages)
{
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