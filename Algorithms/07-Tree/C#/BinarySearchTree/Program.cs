using System;

namespace BinarySearchTree
{
    class BinarySearchTreeImpl
    {
        public class Node
        {
            public int key;
            public Node leftChild, rightChild;

            public Node(int item)
            {
                key = item;
                leftChild = rightChild = null;
            }
        }

        Node root;

        BinarySearchTreeImpl()
        {
            root = null;
        }

        void insert(int key)
        {
            root = insertRec(root, key);
        }

        Node insertRec(Node root, int key)
        {
            if(root == null)
            {
                root = new Node(key);
                return root;
            }

            if (key < root.key)
                root.leftChild = insertRec(root.leftChild, key);
            else if (key > root.key)
                root.rightChild = insertRec(root.rightChild, key);

            return root;
        }

        void preOrder()
        {
            preOrderRec(root);
        }

        void preOrderRec(Node root)
        {
            if (root != null)
            {
                Console.Write(root.key + " ");
                preOrderRec(root.leftChild);
                preOrderRec(root.rightChild);
            }
        }

        void inOrder()
        {
            inOrderRec(root);
        }

        void inOrderRec(Node root)
        {
            if(root!= null)
            {
                inOrderRec(root.leftChild);
                Console.Write(root.key + " ");
                inOrderRec(root.rightChild);
            }
        }

        void postOrder()
        {
            postOrderRec(root);
        }

        void postOrderRec(Node root)
        {
            if (root != null)
            {
                postOrderRec(root.leftChild);
                postOrderRec(root.rightChild);
                Console.Write(root.key + " ");
            }
        }

        public int Search(int data)
        {
            Node current = root;

            while(current.key != data)
            {
                if(current != null)
                {
                    if (current.key > data)
                        current = current.leftChild;
                    else
                        current = current.rightChild;

                    if (current == null)
                        return -1;
                }
            }
            return current.key;
        }

        void deleteKey(int key)
        {
            root = deleteRec(root, key);
        }

        Node deleteRec(Node root, int key)
        {
            if (root == null)
                return root;

            if (key < root.key)
                root.leftChild = deleteRec(root.leftChild, key);

            else if (key > root.key)
                root.rightChild = deleteRec(root.rightChild, key);

            else
            {
                if (root.leftChild == null)
                    return root.rightChild;
                else if (root.rightChild == null)
                    return root.leftChild;

                root.key = minValue(root.rightChild);
                root.rightChild = deleteRec(root.rightChild, root.key);
            }
            return root;
        }

        int minValue(Node root)
        {
            int minv = root.key;

            while(root.leftChild != null)
            {
                minv = root.leftChild.key;
                root = root.leftChild;
            }
            return minv;
        }

        public static void Main(String[] args)
        {
            BinarySearchTreeImpl tree = new BinarySearchTreeImpl();

            /* Let us create following BST 
                  50 
               /     \ 
              30      70 
             /  \    /  \ 
           20   40  60   80 */
            tree.insert(50);
            tree.insert(30);
            tree.insert(20);
            tree.insert(40);
            tree.insert(70);
            tree.insert(60);
            tree.insert(80);

            // Print inorder traversal of the BST 
            Console.WriteLine("In Order Traversal");
            tree.inOrder();
            Console.WriteLine("");

            Console.WriteLine("Pre Order Traversal");
            tree.preOrder();
            Console.WriteLine("");

            Console.WriteLine("Post Order Traversal");
            tree.postOrder();
            Console.WriteLine("");

            Console.WriteLine("Search");
            int result = tree.Search(20);

            if (result == -1)
                Console.WriteLine("Element Not Found");
            else
                Console.WriteLine("Element Found");

            result = tree.Search(90);

            if (result == -1)
                Console.WriteLine("Element Not Found");
            else
                Console.WriteLine("Element Found");

            Console.WriteLine("Delete 20");
            tree.deleteKey(20);
            Console.WriteLine("Inorder traversal of the modified tree");
            tree.inOrder();
        }
    }
}
