using Devops_C_OO.Demo.Datas;
using Devops_C_OO.Demo.Exceptions;
using Devops_C_OO.Demo.Models;
//List<Personnage> personnages = new List<Personnage>()
//{
//    new Hero("Dante"),
//    new Monstre("Toto le malefique"),
//    new Hero("Vergil"),
//};
//try
//{

//Monstre boss = new Monstre("Le mechant");
//boss.Stats[StatType.Pv] = 100;
//boss.Stats[StatType.Force] = -100;
//boss.Stats[StatType.Defence] = 100;
//boss.Stats[StatType.Vitesse] = 100;
//}
//catch(StatNegativeException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//Hero hero = new Hero("Toto");
//hero.Competence1 = Competences.AttaqueMelee;
//hero.Competence2 = Competences.BouleDeFeu;
//hero.Combo = Competences.AttaqueMelee;
//hero.Combo += Competences.BouleDeFeu;
//hero.Combo = Competences.AttaqueMelee;
//hero.test = (int x,int y) => (float)x / y;
//hero.Competence1();
//Console.WriteLine("____________________________");
//hero.Competence2();
//Console.WriteLine("____________________________");
//hero.Combo?.Invoke();
//Console.WriteLine("____________________________");
//Console.WriteLine(hero.test(5 , 3));
//float a = hero.test(5 , 3);

//foreach (Personnage p in personnages)
//{
//    Console.WriteLine(p);
//    p.Frapper(boss);
//    Console.WriteLine("_______________________________________");
//    //switch (p)
//    //{
//    //    case Hero h:
//    //        h.SeSoigner();
//    //        break;
//    //    case Monstre m:
//    //        m.Frapper(m);
//    //        Console.WriteLine("aaaaaaaaaaaaaa");
//    //        break;
//    //}
//}
//personnages.Add((Hero)personnages[0] + (Hero)personnages[2]);
//Console.WriteLine(personnages[3]);
//Console.WriteLine(boss);
//Console.WriteLine(Personnage.CurrentId);

//namespace test
//{
//    public delegate int MathDelegate(int x, int y);
//    public class Program
//    {
//public static void Main(string[] args)
//{
//Console.WriteLine(Add(5, 3));
//MathDelegate mathDel;
//mathDel = delegate (int x, int y)
//{
//    return x + y;
//};
//mathDel = (int x, int y) =>
//{
//    return x + y;
//};
//    mathDel = (int x, int y) => x + y;


//    Console.WriteLine(mathDel(5, 3));

//}
//public static int Add(int x, int y)
//{
//    return x + y;
//}
//    }
//}

Hero h = new Hero("Dante");
Monstre m = new Monstre("Toto");
m.OnDieEvent += h.Loot;

while(h.IsAlive && m.IsAlive)
{
    h.Frapper(m);
    if(m.IsAlive)
        m.Frapper(h);
}
