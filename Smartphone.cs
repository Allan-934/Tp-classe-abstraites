class Smartphone : Appareil
{
    private int nbCapteurPhoto { get; set; }

    // Constructeur pour initialiser les propriétés du smartphone
    public Smartphone(string marque, string modele, DateTime dateFabrication, int nbCapteurPhoto) : base(marque, modele, dateFabrication)
    {
        this.nbCapteurPhoto = nbCapteurPhoto;
    }

    // Redéfinition de la méthode AfficherInfos pour spécifier que c'est un smartphone
    public override void AfficherInfos()
    {
        Console.WriteLine($"Marque: {marque}");
        Console.WriteLine($"Modèle: {modele}");
        Console.WriteLine($"Date de fabrication: {dateFabrication}");
        Console.WriteLine($"Nombre de capteurs photo: {nbCapteurPhoto}");
        CalculerAnciennete();
    }

    // Redéfinition de la méthode CalculerAnciennete pour calculer l'ancienneté d'un smartphone
    public override void CalculerAnciennete()
    {
        var aujourdhui = DateTime.Now;
        var ancien = aujourdhui - dateFabrication;
        Console.WriteLine($"Le smartphone a {ancien.Days / 365} ans.");
    }
}