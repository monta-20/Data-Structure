🔹 Common Properties

Count → number of elements.

Comparer → how equality is checked (default = EqualityComparer<T>.Default).

IsSubsetOf, IsSupersetOf → relationship checks between sets.

🔹 Common Methods

Add(item) → adds an element if not already present (returns true/false).

Remove(item) → removes element.

Contains(item) → check if exists.

Clear() → remove all items.

UnionWith(collection) → combines sets (A ∪ B).

IntersectWith(collection) → keeps only common elements (A ∩ B).

ExceptWith(collection) → removes elements found in another set (A – B).

SymmetricExceptWith(collection) → keeps elements unique to each set (A ⊕ B).


🔹 When to Use HashSet<T> in Web Applications

Ensure uniqueness

Storing unique usernames, emails, product IDs before inserting into DB.

Preventing duplicate API requests or form submissions.

Fast existence checks

Checking if a user already liked a post.

Validating if an item is already in a shopping cart.

Set operations for recommendations

Finding common friends (IntersectWith).

Suggesting items → products a user hasn’t bought (ExceptWith).

Combining multiple result sets (UnionWith).