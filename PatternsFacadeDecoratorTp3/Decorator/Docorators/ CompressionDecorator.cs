using PatternsFacadeDecorator.Decorator.Interfaces;

namespace PatternsFacadeDecorator.Decorator.Decorators;

/// <summary>
/// Décorateur ajoutant une fonctionnalité de compression au fichier
/// </summary>
public class CompressionDecorator : FichierDecorator
{
    /// <summary>
    /// Constructeur initialisant le décorateur avec un fichier à décorer
    /// </summary>
    /// <param name="fichier">Le fichier à décorer</param>
    public CompressionDecorator(IFichier fichier) : base(fichier)
    {
    }

    /// <summary>
    /// Ajoute la compression avant d'enregistrer le fichier
    /// </summary>
    /// <returns>Le résultat de l'enregistrement avec compression</returns>
    public override string Enregistrer()
    {
        string resultat = _fichier.Enregistrer();
        return $"{resultat}\n→ Le fichier '{_fichier.GetNom()}' a été compressé (taille réduite de 60%)";
    }

    /// <summary>
    /// Simule la compression du contenu du fichier
    /// </summary>
    /// <returns>Une représentation du contenu compressé</returns>
    public string CompresserContenu()
    {
        string contenu = _fichier.GetContenu();
        return $"[CONTENU COMPRESSÉ: {contenu.Length} octets → {contenu.Length * 0.4} octets]";
    }
}