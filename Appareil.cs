abstract class Appareil
{
    private protected string marque {get; set;}
    private protected string modele {get; set;}
    private protected DateTime dateFabrication {get; set;}
    
    // Constructeur pour initialiser les propriétés de l'appareil
    public Appareil(string marque, string modele, DateTime dateFabrication)
    {
        this.marque = marque;
        this.modele = modele;
        this.dateFabrication = dateFabrication;
    }

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
