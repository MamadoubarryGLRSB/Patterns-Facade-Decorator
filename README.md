Démonstrateur des Patterns Facade et Decorator
Ce projet démontre l'implémentation et l'utilisation des patterns de conception Facade et Decorator en C#.
Prérequis

.NET 6 (minimum)

Exécution du programme
Pour exécuter le programme, placez-vous dans le répertoire du projet et lancez la commande suivante :

dotnet run

Résultat attendu
Le programme affiche une démonstration complète des patterns Facade et Decorator, avec différentes configurations :

=== Démonstration des patterns Facade et Decorator ===

Fichier original créé:
Fichier texte 'document.txt' enregistré avec le contenu : Contenu confidentiel du document

=== Utilisation du pattern Decorator ===

> Avec compression uniquement:
Fichier texte 'document.txt' enregistré avec le contenu : Contenu confidentiel du document
→ Le fichier 'document.txt' a été compressé (taille réduite de 60%)

> Avec chiffrement uniquement:
Fichier texte 'document.txt' enregistré avec le contenu : Contenu confidentiel du document
→ Le fichier 'document.txt' a été chiffré avec AES-256

> Avec compression ET chiffrement:
Fichier texte 'document.txt' enregistré avec le contenu : Contenu confidentiel du document
→ Le fichier 'document.txt' a été compressé (taille réduite de 60%)
→ Le fichier 'document.txt' a été chiffré avec AES-256

=== Utilisation du pattern Facade ===

> Sauvegarde simple sans option:
=== Démarrage de la sauvegarde du fichier 'document.txt' ===
Étape finale: Enregistrement du fichier...
=== Sauvegarde terminée ===
Fichier texte 'document.txt' enregistré avec le contenu : Contenu confidentiel du document

> Sauvegarde avec compression uniquement:
=== Démarrage de la sauvegarde du fichier 'document.txt' ===
Étape 1: Application de la compression...
Étape finale: Enregistrement du fichier...
=== Sauvegarde terminée ===
Fichier texte 'document.txt' enregistré avec le contenu : Contenu confidentiel du document
→ Le fichier 'document.txt' a été compressé (taille réduite de 60%)

> Sauvegarde avec chiffrement uniquement:
=== Démarrage de la sauvegarde du fichier 'document.txt' ===
Étape 2: Application du chiffrement...
Étape finale: Enregistrement du fichier...
=== Sauvegarde terminée ===
Fichier texte 'document.txt' enregistré avec le contenu : Contenu confidentiel du document
→ Le fichier 'document.txt' a été chiffré avec AES-256

> Sauvegarde complète (compression + chiffrement):
=== Démarrage de la sauvegarde du fichier 'document.txt' ===
Étape 1: Application de la compression...
Étape 2: Application du chiffrement...
Étape finale: Enregistrement du fichier...
=== Sauvegarde terminée ===
Fichier texte 'document.txt' enregistré avec le contenu : Contenu confidentiel du document
→ Le fichier 'document.txt' a été compressé (taille réduite de 60%)
→ Le fichier 'document.txt' a été chiffré avec AES-256

=== Fin de la démonstration ===
