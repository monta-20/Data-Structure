-- AVL Tree
🔹 Qu’est-ce qu’un AVL Tree ?

Un AVL Tree est un Binary Search Tree avec une propriété supplémentaire :

Pour chaque nœud, la différence de hauteur entre son sous-arbre gauche et son sous-arbre droit est au maximum 1.

Formellement :

BalanceFactor = height(left subtree) - height(right subtree)


BalanceFactor ∈ {-1, 0, 1}

Si le facteur est en dehors de cette plage, on fait une rotation pour équilibrer l’arbre.

✅ Cela garantit que les opérations (insertion, suppression, recherche) restent O(log n) même dans le pire des cas.

🔹 Rotations en AVL Tree

Pour maintenir l’équilibre, on utilise 4 types de rotations :

Left Rotation (Rotation à gauche)
Pour corriger un déséquilibre Right-Right (RR).

   y                         x
    \                       / \
     x        →           y   T3
      \
       T3


Right Rotation (Rotation à droite)
Pour corriger un déséquilibre Left-Left (LL).

       y                   x
      /                   / \
     x      →           T1   y
    /
   T1


Left-Right Rotation (LR)
Cas où la branche gauche du nœud est trop profonde à droite.
→ D’abord rotation à gauche sur le fils gauche, puis rotation à droite sur le parent.

Right-Left Rotation (RL)
Cas où la branche droite du nœud est trop profonde à gauche.
→ D’abord rotation à droite sur le fils droit, puis rotation à gauche sur le parent.

🔹 Propriétés
Propriété	AVL Tree
Type	BST auto-équilibré
Hauteur	O(log n)
Recherche	O(log n)
Insertion	O(log n)
Suppression	O(log n)
Utilisation	Base de données, index, systèmes où l’accès rapide est crucial
🔹 Différence avec un BST simple

BST simple peut devenir déséquilibré (ex. insérer 1,2,3,4,5 → arbre devient une liste → O(n) recherche).

AVL restructure automatiquement l’arbre après chaque insertion/suppression.

Link for more info : https://www.w3schools.com/dsa/dsa_data_avltrees.php

-- Red Black Tree

🔹 Qu’est-ce qu’un Red-Black Tree ?

Un Red-Black Tree est un Binary Search Tree (BST) où chaque nœud possède une couleur : rouge (Red) ou noir (Black).
Cette coloration permet de garantir que l’arbre reste approximativement équilibré après insertion et suppression.

🔹 Propriétés principales

Un RBT doit toujours respecter 5 règles :

Chaque nœud est soit rouge, soit noir.

La racine est toujours noire.

Toutes les feuilles nulles (NIL) sont noires.

Si un nœud est rouge, alors ses deux enfants sont noirs.
→ Pas de deux rouges consécutifs.

Tout chemin de la racine à une feuille NIL contient le même nombre de nœuds noirs.
→ On appelle cela le Black Height.

🔹 Pourquoi c’est utile ?

Contrairement à l’AVL Tree, les rotations sont moins fréquentes, car RBT tolère un déséquilibre léger.

Les opérations restent O(log n) : insertion, suppression, recherche.

Très utilisé dans :

Java TreeMap / TreeSet

C++ std::map / std::set

Systèmes de fichiers

Bases de données (indexation)

🔹 Rotations et recolorations

Comme l’AVL Tree, l’arbre peut devenir déséquilibré après une insertion ou suppression, et on utilise :

Rotations

Left Rotation (gauche)

Right Rotation (droite)

Recoloration

On change la couleur des nœuds pour restaurer les propriétés du RBT.

🔹 Exemple d’insertion

Insertion de 10, 20, 30 :

Insérer 10 → racine → noir

Insérer 20 → rouge → aucun problème

Insérer 30 → rouge → parent 20 rouge → violation de la règle 4 → rotation gauche sur 10 + recoloration

Avant rotation :
   10(B)
      \
      20(R)
         \
         30(R)

Après rotation gauche et recoloration :
      20(B)
     /   \
  10(R) 30(R)

🔹 Différence entre AVL et Red-Black Tree
Caractéristique	            AVL Tree	                                         Red-Black Tree
Équilibrage	Strict (hauteur max diff ≤1)	                          Relatif (via couleurs)
Rotations	Plus fréquentes	                                          Moins fréquentes
Recherche	O(log n)	                                              O(log n)
Insertion	Plus coûteuse si rotations fréquentes	                  Plus rapide
Cas d’usage	Accès très rapide, lecture fréquente	                  Lecture/écriture équilibrée, structures STL et Java

For more info : https://www.geeksforgeeks.org/dsa/introduction-to-red-black-tree/