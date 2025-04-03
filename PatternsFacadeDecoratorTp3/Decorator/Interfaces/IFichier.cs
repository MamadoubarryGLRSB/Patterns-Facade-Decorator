namespace PatternsFacadeDecorator.Decorator.Interfaces;

/// <summary>
/// Interface de base pour tous les fichiers dans le système
/// Définit les opérations que tous les fichiers doivent implémenter
/// </summary>
public interface IFichier
{
    /// <summary>
    /// Enregistre le fichier sur le disque
    /// </summary>
    /// <returns>Un message indiquant le résultat de l'opération</returns>
    string Enregistrer();
    
    /// <summary>
    /// Obtient le nom du fichier
    /// </summary>
    /// <returns>Le nom du fichier</returns>
    string GetNom();
    
    /// <summary>
    /// Obtient le contenu du fichier
    /// </summary>
    /// <returns>Le contenu du fichier</returns>
    string GetContenu();
}