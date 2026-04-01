public abstract class Appareil
{
    protected string marque = string.Empty;
    protected string modele = string.Empty;
    protected DateTime dateFabrication;

    // 2. Le constructeur
    public Appareil(string marque, string modele, DateTime dateFabrication)
    {
        // On utilise les méthodes Set pour initialiser (ou les champs directement)
        this.SetMarque(marque);
        this.SetModele(modele);
        this.dateFabrication = dateFabrication;
    }

    // 3. Les Getters et Setters classiques (méthodes)
    
    // Pour la Marque
    public string GetMarque() { return this.marque; }
    public void SetMarque(string valeur) { this.marque = valeur; }

    // Pour le Modèle
    public string GetModele() { return this.modele; }
    public void SetModele(string valeur) { this.modele = valeur; }

    // Pour la Date
    public DateTime GetDateFabrication() { return this.dateFabrication; }
    public void SetDateFabrication(DateTime valeur) { this.dateFabrication = valeur; }

    // Méthode classique pour allumer l'appareil
    public void Allumer() 
    {
        Console.WriteLine("L'appareil est allumé.");
    }
    // Méthode virtuelle pour afficher le type de l'appareil, peut être redéfinie par les classes filles
    public virtual void AfficherType()
    {
        Console.WriteLine("Je suis un appareil.");
    }
    // Méthode virtuelle pour afficher la garantie, peut être redéfinie par les classes filles
    public virtual void AfficherGarantie()
    {
        Console.WriteLine("Garantie standard de l'appareil.");
    }
    // Méthode abstraite pour afficher les informations de l'appareil, doit être Instancié par les classes filles 
    public abstract void AfficherInfos();
    // Méthode abstraite pour calculer l'ancienneté de l'appareil, doit être Instancié par les classes filles
    public abstract void CalculerAnciennete();
}  
