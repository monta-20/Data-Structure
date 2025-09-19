--- Binary Search Tree (BST)
🔹 What is a Binary Search Tree?

A Binary Search Tree (BST) is a special kind of binary tree with the following rules:

Each node has at most two children (left and right).

For every node:

All nodes in the left subtree have values smaller than the node.

All nodes in the right subtree have values larger than the node.

No duplicates (usually).

📌 This property makes searching and inserting very efficient.

🔹 Example BST

Let’s build a BST by inserting numbers:

Insert in this order: 50, 30, 70, 20, 40, 60, 80
ç
        50
       /  \
     30    70
    / \    / \
  20  40  60  80

🔹 Operations on BST
1. Search

Start from root.

If the value is smaller → go left.

If larger → go right.

If equal → found.

Example: Search for 40

50 → go left (30).

30 → go right (40). ✅ Found.

2. Insert

Similar to search, but instead of stopping when the value is not found, insert it there.

Example: Insert 25

50 → go left (30).

30 → go left (20).

20 → go right (null) → Insert 25 here.

3. Traversals

Traversal means visiting nodes in a certain order:

InOrder (Left, Root, Right)

Produces sorted order of values.

For above tree → 20, 30, 40, 50, 60, 70, 80

PreOrder (Root, Left, Right)

Used to copy or serialize a tree.

→ 50, 30, 20, 40, 70, 60, 80

PostOrder (Left, Right, Root)

Used to delete a tree.

→ 20, 40, 30, 60, 80, 70, 50

4. Delete

Deleting a node is trickier:

Case 1: Node has no children (leaf) → Just remove it.

Case 2: Node has one child → Replace node with its child.

Case 3: Node has two children → Replace with the smallest value in right subtree (inorder successor) or largest in left subtree (inorder predecessor).

Example: Delete 50

Replace with 60 (smallest in right subtree).

🔹 Complexity of BST

Best / Average Case (Balanced tree):

Search: O(log n)

Insert: O(log n)

Delete: O(log n)

Worst Case (Unbalanced tree, like a linked list):

Search: O(n)

Insert: O(n)

Delete: O(n)

👉 That’s why we sometimes use balanced BSTs (like AVL Tree or Red-Black Tree) to guarantee efficiency.

🔹 When to Use BST in Real Life?

Databases / Indexing → Efficient searching & sorting.

Autocomplete features → Store dictionary words in BST.

Search engines → Indexing data.

Compilers → Managing symbol tables.

File systems → Organizing files by keys.

-- Link for more info : https://www.w3schools.com/dsa/dsa_data_binarysearchtrees.php
