using System;

namespace Recursion_task;
class Tree
{
    public static void Main(string[] args)
    {
        Branch root = new Branch();
        Branch b1 = new Branch();
        Branch b2 = new Branch();
        Branch b3 = new Branch();
        Branch b4 = new Branch();
        Branch b5 = new Branch();
        Branch b6 = new Branch();
        Branch b7 = new Branch();
        Branch b8 = new Branch();
        Branch b9 = new Branch();
        Branch b10 = new Branch();
        Branch b11 = new Branch();
        root.branches.Add(b1);
        root.branches.Add(b2);
        b1.branches.Add(b3);
        b2.branches.Add(b4);
        b2.branches.Add(b5);
        b2.branches.Add(b6);
        b3.branches.Add(b7);
        b4.branches.Add(b8);
        b4.branches.Add(b9);
        b5.branches.Add(b10);
        b8.branches.Add(b11);

        PrintTree(root, 0);
        Console.WriteLine("Depth of the tree: " + depth(root));
    }

    public static void PrintTree(Branch root, int level)
    {
        if (root.branches.Count == 0)
        {
            Console.WriteLine(new String(' ', level) + "Leaf");
        }
        else
        {
            Console.WriteLine(new String(' ', level) + "Branch (" + level + ")");
            foreach (Branch b in root.branches)
            {
                PrintTree(b, level + 1);
            }
        }
    }

    public static int depth(Branch root)
    {
        if (root.branches.Count == 0)
        {
            return 1;
        }
        else
        {
            int maxDepth = 0;
            foreach (Branch b in root.branches)
            {
                maxDepth = Math.Max(maxDepth, depth(b));
            }
            return maxDepth + 1;
        }
    }
}

