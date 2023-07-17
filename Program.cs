namespace cSharp_BinarySearchTree_BST_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree BST = new BinarySearchTree();
            BST.Add(7);
            BST.Add(5);
            BST.Add(3);
            BST.Add(10);
            BST.Add(9);
            BST.Add(20);
            BST.Add(2);
            BST.Add(4);
            //Console.WriteLine("The Root of this tree is "+ BST.Root);
            Console.WriteLine("-_- Traverse InOrder -_-\n");
            BST.TraverseInOrder(BST.Root);
            Console.WriteLine("\r\n-_- Traverse PostOrder -_-\n");
            BST.TraversePostOrder(BST.Root);
            Console.WriteLine("\r\n-_- Traverse PreOrder -_-\n");
            BST.TraversePreOrder(BST.Root);






        }

    }
}