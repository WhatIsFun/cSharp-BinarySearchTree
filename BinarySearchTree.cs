using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_BinarySearchTree_BST_
{
    internal class BinarySearchTree
    {
        public Node Root { get; set; }

        public bool Add(int value)
        {
            Node before = null, after = this.Root;

            while (after != null)
            {
                before = after;
                if (value < after.item) // right
                {
                    after = after.left;
                }
                else if (value > after.item) // left
                {
                    after = after.right;
                }
                else
                {
                    return false;
                }
            }

            Node newNode = new Node();
            newNode.item = value;

            if (this.Root == null) //Tree is empty
                this.Root = newNode;
            else
            {
                if (value < before.item)
                { before.left = newNode; }
                else
                { before.right = newNode; }
            }
            return true;
        }
        
        // InOrder Traversal:
        // Traverse the left subtree
        // Visit the root
        // Traverse the right subtree
        public void TraverseInOrder(Node parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.left);
                Console.Write(parent.item + " ");
                TraverseInOrder(parent.right);
            }
        }
        
        // PostOrder Traversal:
        // Traverse the left subtree
        // Traverse the right subtree
        // Visit the root
        public void TraversePostOrder(Node parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.left);
                TraversePostOrder(parent.right);
                Console.Write(parent.item + " ");
            }
        }

        // PreOrder Traversal:
        // Visit the root
        // Traverse the left subtree
        // Traverse the right subtree
        public void TraversePreOrder(Node parent)
        {
            if (parent != null)
            {
                Console.Write(parent.item + " ");
                TraversePreOrder(parent.left);
                TraversePreOrder(parent.right);
            }
        }
    }
}
    
