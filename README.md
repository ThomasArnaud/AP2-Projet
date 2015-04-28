Stupide vautour
===============

# Présentation du projet
Le projet du cours d'algorithmique et prorammation 2 consiste à implémenter
une version du jeu [Stupide Vautour](http://fr.wikipedia.org/wiki/Stupide_vautour) créé
par Alex Randolph en 1988.

L'application devra permettre à un utilisateur de jouer contre jusqu'à quatre
intelligences articielles pouvant être de trois difficultés différentes : facile,
moyenne et difficile.

# Déroulement d'une partie
## Création d'une partie
Lorsque l'utilisateur lance une nouvelle partie, une fenêtre de dialogue est ouverte
pour qu'il renseigne les paramètres de la partie : son nom, à combien d'adversaires
il s'oppose ainsi que leur difficulté. Une fois ses paramètres saisis, on crée
les joueurs puis le jeu. Il faudra vérifier qu'il y a au moins deux joueurs sinon
il ne faut pas pouvoir jouer. Tous les boutons des cartes sont bloqués puis affichés.
Ils seront débloqués une fois le jeu totalement créé.

## Déroulement d'une partie
Le joueur humain sera le premier à jouer dans tous les cas. Lorsqu'il cliquera sur
un des boutons représentant une de ses cartes, l'interface fera appel à une méthode
du jeu avec la carte jouée par l'utilisateur.

Cette méthode récupèrera les cartes des autres joueurs, c'est-à-dire les IA, et
effectuera les comparaisons entre les cartes pour déterminer le gagnant ou le perdant
de la manche.

Quand ce n'est pas au tour de l'utilisateur, tous les boutons représentant ses cartes
sont bloqués. Lorsqu'une carte est jouée, elle n'est plus affichée et le bouton
associé est caché.

# Intelligences artificielle
## Facile
* Joue aléatoirement
* Restriction des choix possibles de carte en fonction de la carte jouée

## Moyenne
* Attribution de plages de cartes à utiliser selon la carte à récupérer ou éviter
    * [8 12] : plage des cartes négatives
    * [10 15] : plage des meilleures cartes
    * [1 8] : plage des cartes restantes
* Définition d'un seul à partir duquel la carte devient intéressante et doit être
remportée

## Difficile
* Basée sur l'IA moyenne
* Prise en compte des cartes jouées par les adversaires afin de construire les
plages de cartes possibles en définissant le nombre à partir duquel il est plus
sûr de jouer une carte.

# Critères d'évaluation
* Qualité de l'interface : ergonomie, facilité d'utilisation
* Qualité du code : code factorisé, bien commenté
* Temps de réponse des IAs : < 3s ou < 4s
* Présence de bugs
* Qualité du travail de groupe
* Questions sur le code
