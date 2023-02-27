using System;
using Day15BinarySearchTree;

public class Program{
    public static void Main(string[] args)
    {
        Day15BinarySearchTree.BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(40);
            bst.Insert(11);
            bst.Insert(16);
            bst.Insert(22);
            bst.Insert(3);
            bst.Insert(63);
            bst.Insert(67);
            bst.Insert(60);
            bst.Insert(95);
            bst.Insert(65);
             Node node63 = bst.Search(63);
                if (node63 == null)
                 {
                    Console.WriteLine("Node not found");
                 }
                else
                {
                    Console.WriteLine("Node found: " + node63.data);
                }
           
    }

}