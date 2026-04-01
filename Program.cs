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

        // Exercice 4 Creation d'un new ordi avec une date diff 
        Ordinateur o2 = new Ordinateur("HP", "Pavilion", new DateTime(2018, 3, 15), 14);
        o2.CalculerAnciennete();

        Console.WriteLine("\n-----------------------------\n");

        //Exercice 3 : Création d'un nouveau smartphone + test des méthodes
        Smartphone s1 = new Smartphone("Apple", "iPhone 13", new DateTime(2021, 9, 24), 3);
        s1.Allumer();
        s1.AfficherType();
        s1.AfficherGarantie();
        s1.AfficherInfos();

        // Exercice 4 Creation d'un new smartphone avec une date diff 
        Smartphone s2 = new Smartphone("Samsung", "Galaxy S20", new DateTime(2020, 2, 11), 4);
        s2.CalculerAnciennete();

        // Exercice 5 : Création d'une liste d'appareils et affichage de leurs informations 
        List<Appareil> appareils = new List<Appareil>();
        appareils.Add(o1);
        appareils.Add(s1);

        foreach (Appareil appareil in appareils)
        {
            Console.WriteLine("---");
            appareil.Allumer();
            appareil.AfficherType();
            appareil.AfficherGarantie();
            appareil.AfficherInfos();
        }
    }
}
