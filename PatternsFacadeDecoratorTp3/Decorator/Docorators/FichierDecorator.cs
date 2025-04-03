using PatternsFacadeDecorator.Decorator.Interfaces;

namespace PatternsFacadeDecorator.Decorator.Decorators;

/// <summary>
/// Classe de base abstraite pour tous les décorateurs de fichiers
/// Implémente le pattern Decorator
/// </summary>
public abstract class FichierDecorator : IFichier
{
    // Le fichier décoré
    protected IFichier _fichier;

    /// <summary>
    /// Constructeur initialisant le décorateur avec un fichier à décorer
    /// </summary>
    /// <param name="fichier">Le fichier à décorer</param>
    public FichierDecorator(IFichier fichier)
    {
        _fichier = fichier;
    }

    /// <summary>
    /// Redirige l'appel vers le fichier décoré (peut être surchargé)
    /// </summary>
    /// <returns>Le résultat de l'enregistrement</returns>
    public virtual string Enregistrer()
    {
        return _fichier.Enregistrer();
    }

    /// <summary>
    /// Redirige l'appel vers le fichier décoré
    /// </summary>
    /// <returns>Le nom du fichier</returns>
    public string GetNom()
    {
        return _fichier.GetNom();
    }

    /// <summary>
    /// Redirige l'appel vers le fichier décoré
    /// </summary>
    /// <returns>Le contenu du fichier</returns>
    public string GetContenu()
    {
        return _fichier.GetContenu();
    }
}