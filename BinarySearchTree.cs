namespace Training_console
{
    class BinarySearchTree
    {
        public Node Root;
        public BinarySearchTree()
        {
            Root = null;
        }
        public void Insert(int v)
        {
            Root = InsertRec(Root, v);
        }
        private Node InsertRec(Node root, int v)
        {
            if (root == null)
            {
                return new Node(v);
            }
            if (v > root.value)
            {
                root.right = InsertRec(root.right, v);
            }
            else if (v < root.value)
            {
                root.left = InsertRec(root.left, v);
            }
            return root;
        }
        public bool Search(int v)
        {
            return SearchRec(Root, v);
        }
        private bool SearchRec(Node root, int v)
        {
            if (root == null) return false;
            if (root.value == v) return true;
            if (v > root.value)
            {
                return SearchRec(root.right, v);
            }
            else
            {
                return SearchRec(root.left, v);
            }
        }
        public void Delete(int v)
        {
            Root = DeleteRec(Root, v);
        }
        private Node DeleteRec(Node root, int v)
        {
            if (root == null) return root;
            if (v < root.value)
            {
                root.left = DeleteRec(root.left, v);
            }
            else if (v > root.value)
            {
                root.right = DeleteRec(root.right, v);
            }
            else
            {
                // Node with only one child or no child
                if (root.left == null)
                    return root.right;
                else if (root.right == null)
                    return root.left;
                // Node with two children: Get the inorder successor (smallest in the right subtree)
                root.value = MinValue(root.right);
                // Delete the inorder successor
                root.right = DeleteRec(root.right, root.value);
            }
            return root;
        }

        // Helper method to find the minimum value in a subtree
        private int MinValue(Node root)
        {
            int minValue = root.value;
            while (root.left != null)
            {
                minValue = root.left.value;
                root = root.left;
            }
            return minValue;
        }

        // InOrder
        public void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.left);
                Console.WriteLine(root.value);
                InOrder(root.right);
            }
        }

        // PreOrder
        public void PreOrder(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.value);
                PreOrder(root.left);
                PreOrder(root.right);
            }
        }

        // PostOrder
        public void PostOrder(Node root)
        {
            if (root != null)
            {
                PostOrder(root.left);
                PostOrder(root.right);
                Console.WriteLine(root.value);
            }
        }
    }
}
