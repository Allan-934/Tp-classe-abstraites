class Ordinateur : Appareil 
{
    private double tailleEcran { get; set; }

    // Constructeur pour initialiser les propriétés de l'ordinateur
    public Ordinateur(string marque, string modele, DateTime dateFabrication, double tailleEcran) : base(marque, modele, dateFabrication)
    {
        this.tailleEcran = tailleEcran;
    }

    // Redéfinition de la méthode AfficherType pour spécifier que c'est un ordinateur
    public override void AfficherType()
    {
        Console.WriteLine("Je suis un ordinateur.");
    }

    // Redéfinition de la méthode CalculerAnciennete pour calculer l'ancienneté d'un ordinateur
    public override void CalculerAnciennete()
    {
        var aujourdhui = DateTime.Now;
        var ancien = aujourdhui - dateFabrication;
        Console.WriteLine($"L'ordinateur a {ancien.Days / 365} ans.");
    }
    // Redéfinition de la méthode AfficherGarantie pour spécifier une garantie différente pour les ordinateurs
    public override void AfficherGarantie()
    {
        Console.WriteLine("Garantie pour les ordinateurs.");
    }


    // Redéfinition de la méthode Afficherinfos pour spécifier une garantie différente pour les ordinateurs
    public override void AfficherInfos()
    {
        Console.WriteLine($"Marque: {marque}");
        Console.WriteLine($"Modèle: {modele}");
        Console.WriteLine($"Date de fabrication: {dateFabrication}");
        Console.WriteLine($"Taille de l'écran: {tailleEcran} pouces");
        CalculerAnciennete(); 
    }
    // Redéfinition de la méthodde ToString pour afficher les informations de l'ordinateur 
    public override string ToString()
    {
        return $"Ordinateur - Marque: {marque}, Modèle: {modele}, Date de fabrication: {dateFabrication}, Taille de l'écran: {tailleEcran}";
    }
}
