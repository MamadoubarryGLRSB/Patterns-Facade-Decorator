using PatternsFacadeDecorator.Decorator.Interfaces;

namespace PatternsFacadeDecorator.Decorator.Decorators;

/// <summary>
/// Décorateur ajoutant une fonctionnalité de chiffrement au fichier
/// </summary>
public class ChiffrementDecorator : FichierDecorator
{
    /// <summary>
    /// Constructeur initialisant le décorateur avec un fichier à décorer
    /// </summary>
    /// <param name="fichier">Le fichier à décorer</param>
    public ChiffrementDecorator(IFichier fichier) : base(fichier)
    {
    }

    /// <summary>
    /// Ajoute le chiffrement avant d'enregistrer le fichier
    /// </summary>
    /// <returns>Le résultat de l'enregistrement avec chiffrement</returns>
    public override string Enregistrer()
    {
        string resultat = _fichier.Enregistrer();
        return $"{resultat}\n→ Le fichier '{_fichier.GetNom()}' a été chiffré avec AES-256";
    }

    /// <summary>
    /// Simule le chiffrement du contenu du fichier
    /// </summary>
    /// <returns>Une représentation du contenu chiffré</returns>
    public string ChiffrerContenu()
    {
        string contenu = _fichier.GetContenu();
        return $"[CONTENU CHIFFRÉ: {new string('*', contenu.Length)}]";
    }
}