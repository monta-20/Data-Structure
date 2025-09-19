--- Binary Tree : 
🔹 Types of Binary Trees
1. Balanced Binary Tree

Definition: For every node, the height difference between the left and right subtree is at most 1.

Ensures that the tree does not become skewed (like a linked list).

Example: AVL Trees, Red-Black Trees.

✅ Use case: Faster searches in databases or indexing systems because the tree stays balanced.

2. Complete Binary Tree

Definition: All levels are completely filled, except possibly the last level, which is filled from left to right.

A complete binary tree is also balanced by definition.

✅ Use case: Heaps (used in Priority Queues) are complete binary trees.

3. Full Binary Tree

Definition: Every node has either 0 or 2 children.

No node has only one child.

✅ Use case: Useful in cases like decision trees, where each decision splits into exactly two possible outcomes.

4. Perfect Binary Tree

Definition:

All internal nodes have exactly 2 children.

All leaf nodes are at the same level.

This means every level is completely filled.

A perfect binary tree is also full, balanced, and complete.

✅ Use case: Efficient memory representation, often used in network routing or hierarchical data structures.

🔹 Visual Summary

Balanced Tree: Keeps height difference ≤ 1.

Complete Tree: All levels filled except possibly the last (left-to-right).

Full Tree: Each node has 0 or 2 children.

Perfect Tree: Full + Complete → All leaves at the same depth.

-- Link for more info : https://www.w3schools.com/dsa/dsa_data_binarytrees.php
