namespace Tp_classe_abstraites;

class Program
{
    static void Main(string[] args)
    {
        // Création d'un nouvelle ordianteur + test des méthodes
        Ordinateur o1 = new Ordinateur("Dell", "XPS 15", new DateTime(2020, 5, 1), 15.6);
        o1.Allumer();
        o1.AfficherType();
        o1.AfficherGarantie();
        o1.AfficherInfos();
        Console.WriteLine(o1);
    }
}
