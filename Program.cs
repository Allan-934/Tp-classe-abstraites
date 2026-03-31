namespace Tp_classe_abstraites;

class Program
{
    static void Main(string[] args)
    {
        //Exercice 2 : Création d'un nouvelle ordianteur + test des méthodes
        Ordinateur o1 = new Ordinateur("Dell", "XPS 15", new DateTime(2020, 5, 1), 15.6);
        o1.Allumer();
        o1.AfficherType();
        o1.AfficherGarantie();
        o1.AfficherInfos();
        Console.WriteLine(o1);

        Console.WriteLine("\n-----------------------------\n");

        //Exercice 3 : Création d'un nouveau smartphone + test des méthodes
        Smartphone s1 = new Smartphone("Apple", "iPhone 13", new DateTime(2021, 9, 24), 3);
        s1.Allumer();
        s1.AfficherType();
        s1.AfficherGarantie();
        s1.AfficherInfos();
    }
}
