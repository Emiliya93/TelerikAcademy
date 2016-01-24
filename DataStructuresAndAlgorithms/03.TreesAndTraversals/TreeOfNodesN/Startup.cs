namespace TreeOfNodesN
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            int numberOfNodes = int.Parse(Console.ReadLine());

            //var tree = new List<Node>();
            var tree = new Node<int>[numberOfNodes];

            for (int i = 0; i < numberOfNodes; i++)
            {
                tree[i] = new Node<int>(i);
            }

            for (int i = 0; i < numberOfNodes - 1; i++)
            {
                string input = Console.ReadLine();
                string[] nodesRelashionship = input.Split(' ');

                int parentNodeValue = int.Parse(nodesRelashionship[0]);
                int childNodeValue = int.Parse(nodesRelashionship[1]);

                tree[parentNodeValue].AddChildNode(tree[childNodeValue]);
            }

            // 1.Find root node
            int rootValue = FindRoot(tree);
            Console.WriteLine("Tree root is: {0}", rootValue);

            // 2.Leaf nodes
            List<Node<int>> leafNodes = FindLeafs(tree);
            Console.Write("Leafs: ");
            Console.WriteLine(string.Join(", ", leafNodes));

            // 3.
            List<Node<int>> middleNodes = FindMiddleNodes(tree);
            Console.Write("Middle nodes: ");
            Console.WriteLine(string.Join(", ", middleNodes));
        }

        private static List<Node<int>> FindLeafs(Node<int>[] tree)
        {
            List<Node<int>> leafs = new List<Node<int>>();

            for (int i = 0; i < tree.Length; i++)
            {
                if (tree[i].ChildNodes.Count == 0)
                {
                    leafs.Add(tree[i]);
                }
            }

            return leafs;
        }

        private static int FindRoot(Node<int>[] tree)
        {
            bool[] hasParent = new bool[tree.Length];

            foreach (var node in tree)
            {
                foreach (var child in node.ChildNodes)
                {
                    hasParent[child.Value] = true;
                }
            }

            for (int i = 0; i < hasParent.Length; i++)
            {
                if (!hasParent[i])
                {
                    return i;
                }
            }

            throw new ArgumentOutOfRangeException("Tree has no root.");
        }

        private static List<Node<int>> FindMiddleNodes(Node<int>[] tree)
        {
            int length = tree.Length;
            bool[] hasParent = new bool[length];
            bool[] hasChildren = new bool[length];

            foreach (var node in tree)
            {
                foreach (var child in node.ChildNodes)
                {
                    hasChildren[node.Value] = true;
                    hasParent[child.Value] = true;
                }
            }

            var middleNodes = new List<Node<int>>();
            for (int i = 0; i < length; i++)
            {
                if (hasParent[i] && hasChildren[i])
                {
                    middleNodes.Add(tree[i]);
                }
            }

            return middleNodes;
        }
    }
}
