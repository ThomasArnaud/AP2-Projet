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
* Algorithme __glouton__ : meilleure solution locale
* Si la carte est négative, chercher à l'éviter avec des cartes moyennes
* Si la carte dépasse le seuil, toujours jouer les meilleures cartes
* Sinon, jouer aléatoirement dans les cartes moyennes

## Difficile
* Algorithme __brutal__ : solution optimale
* Voir algorithme de Monte-carlo et UCB
* Simuler le restant du jeu dans une méthode récursive de la classe et regarder
ce qui a la meilleure probabilité de gagner

# Evaluation
* Qualité de l'interface : ergonomie, facilité d'utilisation
* Qualité du code : code factorisé, bien commenté
* Temps de réponse des IAs : < 3s ou < 4s
* Présence de bugs
* Qualité du travail de groupe
* Questions sur le code
