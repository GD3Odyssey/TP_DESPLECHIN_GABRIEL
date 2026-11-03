# TP_DESPLECHIN_GABRIEL

1. Présentation

Fonctionnement visé

Quand le joueur clique sur une compétence de la barre d'actions :

1. le personnage joue son animation d'attaque ;
2. un projectile est instancié et se déplace vers la cible (DOTween) ;
3. à l'arrivée, la cible subit des dégâts ;
4. un effet visuel apparaît à l'impact ;
5. la barre de vie de la cible se met à jour (animée avec DOTween) ;
6. la compétence entre en recharge et son bouton est désactivé jusqu'à la fin du cooldown.

Principes d'architecture

Définition et état séparés: une compétence est décrite par un `ScriptableObject` (`AbilityData`) qui ne contient que des données fixes. Le temps de recharge restant est géré par l'`AbilityManager`, pas par le ScriptableObject.

Composants indépendants: `Health` ne connaît pas l'interface. Il expose des événements `System.Action` (changement de vie, mort) auxquels l'interface s'abonne.

Interface générée dynamiquement : les boutons de la barre de compétences sont créés à partir de la liste d'`AbilityData`. Ajouter une ressource suffit à faire apparaître un bouton.

2. Installation

Version de Unity : 6.3
Pipeline de rendu : Universal Render Pipeline (URP)
Gestion des entrées : ancien Input Manager (réglage du projet)
Dépendances : DOTween (inclus dans `Assets/DOTween`), TextMesh Pro (essentiels, inclus).

Ouvrir le dossier du projet avec Unity Hub, puis charger la scène `Assets/_Project/Scenes/SampleScene.unity` et lancer le mode Play. Aucune autre manipulation n'est nécessaire.

3. Organisation du projet

Vous trouverez tout dans le dossier "Project"
```
4. Assets externes

 https://kaylousberg.itch.io/kaykit-adventurers | Modèles 3D du Barbarian (joueur) et accessoires.
 https://kaylousberg.itch.io/kaykit-character-animations | Animations des personnages (idle, marche, attaques) et modèle du mannequin (cible).
 https://marketplace.unity.com/packages/vfx/particles/spells/magic-effects-free-247933 | Effets visuels de projectiles et d'impacts |
 https://assetstore.unity.com/packages/vfx/particles/hit-effects-free-284613 (Unity Asset Store) | Effets visuels d'impact à l'arrivée des projectiles |
 https://dotween.demigiant.com/ | Déplacement des projectiles et animation de l'interface |
 TextMesh Pro | Unity Technologies | Package Unity (essentiels) | Textes de l'interface |

Les packs externes sont conservés dans `Assets/ThirdParty` sans modification de leur contenu.


