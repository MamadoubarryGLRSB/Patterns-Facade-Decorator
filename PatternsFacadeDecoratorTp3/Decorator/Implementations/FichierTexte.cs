using PatternsFacadeDecorator.Decorator.Interfaces;

namespace PatternsFacadeDecorator.Decorator.Implementations;

/// <summary>
/// Implémentation concrète d'un fichier texte
/// </summary>
public class FichierTexte : IFichier
{
    private string _nom;
    private string _contenu;

    /// <summary>
    /// Constructeur initialisant un fichier texte avec son nom et contenu
    /// </summary>
    /// <param name="nom">Nom du fichier</param>
    /// <param name="contenu">Contenu textuel du fichier</param>
    public FichierTexte(string nom, string contenu)
    {
        _nom = nom;
        _contenu = contenu;
    }

    /// <summary>
    /// Enregistre le fichier texte sans traitement particulier
    /// </summary>
    /// <returns>Message confirmant l'enregistrement</returns>
    public string Enregistrer()
    {
        return $"Fichier texte '{_nom}' enregistré avec le contenu : {_contenu}";
    }

    /// <summary>
    /// Obtient le nom du fichier
    /// </summary>
    /// <returns>Le nom du fichier</returns>
    public string GetNom()
    {
        return _nom;
    }

    /// <summary>
    /// Obtient le contenu du fichier
    /// </summary>
    /// <returns>Le contenu textuel du fichier</returns>
    public string GetContenu()
    {
        return _contenu;
    }
}