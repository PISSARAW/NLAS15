# NLAS15

Application Windows Forms développée en C# (.NET Framework 4.6.1) permettant la gestion du personnel et des visiteurs d'une structure (employés, stagiaires, bénévoles, invités, visites). L'interface utilise les composants DevExpress et les données sont stockées dans une base SQL Server.

## Fonctionnalités

- **Authentification** des utilisateurs au démarrage de l'application.
- **Gestion du personnel** : création et consultation des employés, stagiaires et bénévoles.
- **Gestion des visiteurs** : enregistrement des invités et suivi des visites.
- **Portail d'accueil (VPortail)** centralisant l'accès aux différents modules.
- **Statistiques sur les stages** (StatStag).
- **Espace administrateur** pour la supervision.
- **Écran de démarrage** (SplashScreen) et boîte « À propos ».

## Structure du projet

```
NLAS15/
├── NLAS15.sln              # Solution Visual Studio
├── packages/               # Dépendances NuGet (DevExpress, etc.)
└── NLAS15/
    ├── Program.cs          # Point d'entrée et chaîne de connexion SQL
    ├── Authentification.*  # Écran de connexion
    ├── VPortail.* / Vportail.Designer.cs  # Portail principal
    ├── Admin.cs            # Module administrateur
    ├── Creer*.cs           # Formulaires de création (Employé, Bénévole, Stagiaire, Guest)
    ├── Ren*.cs             # Formulaires de renseignement / consultation
    ├── Stat*.cs            # Statistiques
    ├── Personne.cs, Personnel.cs, Benevole.cs, Stagiaire.cs,
    │   Visiteur.cs, Visite.cs, Stage.cs, Ligue.cs, Model1.cs
    │                        # Classes métier
    ├── *.xsd / *.xsc / *.xss  # DataSets typés
    ├── app.config          # Configuration de l'application
    └── packages.config     # Liste des paquets NuGet
```

## Prérequis

- **Windows** avec **Visual Studio 2015** ou version ultérieure.
- **.NET Framework 4.6.1**.
- **SQL Server** avec une base nommée `ETP` accessible.
- Composants **DevExpress** (récupérés via les paquets NuGet du dossier `packages/`).

## Installation

1. Cloner le dépôt :
   ```bash
   git clone https://github.com/PISSARAW/NLAS15.git
   ```
2. Ouvrir `NLAS15.sln` dans Visual Studio.
3. Restaurer les paquets NuGet (clic droit sur la solution → *Restore NuGet Packages*).
4. Adapter la chaîne de connexion à la base de données dans `NLAS15/Program.cs` (classe `Connection`) :
   ```csharp
   connexion = new SqlConnection(@"Data Source=MON_SERVEUR;Initial Catalog=ETP;Integrated Security=True");
   ```
5. Compiler la solution (`Ctrl+Shift+B`).

## Utilisation

Lancer le projet depuis Visual Studio (`F5`) ou exécuter le binaire généré dans `NLAS15/bin/Debug/NLAS15.exe`. L'application démarre sur l'écran d'authentification puis donne accès au portail principal.

## Licence

Projet à usage interne. Aucune licence n'a été spécifiée par l'auteur.
