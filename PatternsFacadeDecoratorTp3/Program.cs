using PatternsFacadeDecorator.Decorator.Implementations;
using PatternsFacadeDecorator.Decorator.Decorators;
using PatternsFacadeDecorator.Decorator.Interfaces;
using PatternsFacadeDecorator.Facade;

namespace PatternsFacadeDecorator;

/// <summary>
/// Classe principale du programme pour tester les patterns Facade et Decorator
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Démonstration des patterns Facade et Decorator ===\n");
        
        // 1. Création d'un fichier texte simple
        IFichier fichierOriginal = new FichierTexte("document.txt", "Contenu confidentiel du document");
        Console.WriteLine("Fichier original créé:");
        Console.WriteLine(fichierOriginal.Enregistrer());
        Console.WriteLine();
        
        // 2. Utilisation directe des décorateurs (Pattern Decorator)
        Console.WriteLine("=== Utilisation du pattern Decorator ===");
        
        // Application de la compression seule
        Console.WriteLine("\n> Avec compression uniquement:");
        IFichier fichierCompresse = new CompressionDecorator(fichierOriginal);
        Console.WriteLine(fichierCompresse.Enregistrer());
        
        // Application du chiffrement seul
        Console.WriteLine("\n> Avec chiffrement uniquement:");
        IFichier fichierChiffre = new ChiffrementDecorator(fichierOriginal);
        Console.WriteLine(fichierChiffre.Enregistrer());
        
        // Combinaison des deux décorateurs (compression puis chiffrement)
        Console.WriteLine("\n> Avec compression ET chiffrement:");
        IFichier fichierSecurise = new ChiffrementDecorator(new CompressionDecorator(fichierOriginal));
        Console.WriteLine(fichierSecurise.Enregistrer());
        
        // 3. Utilisation de la facade (Pattern Facade)
        Console.WriteLine("\n=== Utilisation du pattern Facade ===");
        
        var sauvegardeManager = new SauvegardeManager();
        
        // Utilisation de la façade avec différentes options
        Console.WriteLine("\n> Sauvegarde simple sans option:");
        Console.WriteLine(sauvegardeManager.SauvegarderFichier(fichierOriginal));
        
        Console.WriteLine("\n> Sauvegarde avec compression uniquement:");
        Console.WriteLine(sauvegardeManager.SauvegarderFichier(fichierOriginal, compresser: true));
        
        Console.WriteLine("\n> Sauvegarde avec chiffrement uniquement:");
        Console.WriteLine(sauvegardeManager.SauvegarderFichier(fichierOriginal, chiffrer: true));
        
        Console.WriteLine("\n> Sauvegarde complète (compression + chiffrement):");
        Console.WriteLine(sauvegardeManager.SauvegarderFichierSecurise(fichierOriginal));
        
        Console.WriteLine("\n=== Fin de la démonstration ===");
    }
}