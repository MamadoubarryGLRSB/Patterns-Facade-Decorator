using PatternsFacadeDecorator.Decorator.Interfaces;
using PatternsFacadeDecorator.Decorator.Decorators;

namespace PatternsFacadeDecorator.Facade;

/// <summary>
/// Classe façade qui simplifie l'interface pour sauvegarder un fichier avec compression et chiffrement
/// Implémente le pattern Facade
/// </summary>
public class SauvegardeManager
{
    /// <summary>
    /// Sauvegarde un fichier avec options de compression et chiffrement
    /// </summary>
    /// <param name="fichier">Le fichier à sauvegarder</param>
    /// <param name="compresser">Indique si le fichier doit être compressé</param>
    /// <param name="chiffrer">Indique si le fichier doit être chiffré</param>
    /// <returns>Le résultat des opérations</returns>
    public string SauvegarderFichier(IFichier fichier, bool compresser = false, bool chiffrer = false)
    {
        Console.WriteLine($"=== Démarrage de la sauvegarde du fichier '{fichier.GetNom()}' ===");
        
        IFichier fichierATraiter = fichier;
        
        // Application des décorateurs selon les options
        if (compresser)
        {
            Console.WriteLine("Étape 1: Application de la compression...");
            fichierATraiter = new CompressionDecorator(fichierATraiter);
        }
        
        if (chiffrer)
        {
            Console.WriteLine("Étape 2: Application du chiffrement...");
            fichierATraiter = new ChiffrementDecorator(fichierATraiter);
        }
        
        Console.WriteLine("Étape finale: Enregistrement du fichier...");
        string resultat = fichierATraiter.Enregistrer();
        
        Console.WriteLine("=== Sauvegarde terminée ===");
        return resultat;
    }
    
    /// <summary>
    /// Version simplifiée qui applique automatiquement compression et chiffrement
    /// </summary>
    /// <param name="fichier">Le fichier à sauvegarder</param>
    /// <returns>Le résultat des opérations</returns>
    public string SauvegarderFichierSecurise(IFichier fichier)
    {
        return SauvegarderFichier(fichier, true, true);
    }
}